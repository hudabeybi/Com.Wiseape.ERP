using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Text;
using System.Data.Entity;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Com.Wiseape.Framework
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {

        protected string DataContextKey
        {
            set;
            get;
        }

        protected DbContext context;

        protected DbContext DataContext
        {
            get
            {
                if(context == null)
                    context = (DbContext)Com.Wiseape.Factory.DataContextFactory.Create(DataContextKey);
                return context;
            }
        }

        public BaseRepository()
        {

        }

        public BaseRepository(String dataContextKey)
        {
            context = (DbContext)Com.Wiseape.Factory.DataContextFactory.Create(dataContextKey);
        }
        public virtual void Add(object instance)
        {
            DataContext.Set<T>().Add((T)instance);
            DataContext.SaveChanges();
        }


        public virtual void Delete(object id)
        {
            object instance = Get(id);
            DataContext.Set<T>().Remove((T)instance);
            DataContext.SaveChanges();
        }

        public virtual Int64 GetTotal(SelectParam selectParam)
        {
            Int64 total = 0;
            if (selectParam != null && selectParam.Where != null)
                total = DataContext.Set<T>().Where(selectParam.Where).Count();
            else
                total = DataContext.Set<T>().Count();
            return total;
        }

        public virtual List<T> FindAll(SelectParam selectParam, int? page, int? size)
        {
            List<T> items = null;

            if (selectParam != null && selectParam.OrderBy.Count == 0)
            {
                PropertyInfo prop = Wiseape.Utility.Assembly.GetKeyProperty(typeof(T));
                if (prop != null)
                    selectParam.AddOrderBy(prop.Name);
            }
            
            if (page == null || size == null)
            {
                if(selectParam != null && selectParam.Where != null)
                    items = DataContext.Set<T>().Where(selectParam.Where).OrderBy( selectParam.OrderByString ).ToList<T>();
                else if (selectParam != null)
                    items = DataContext.Set<T>().OrderBy( selectParam.OrderByString).ToList<T>();
                else
                    items = DataContext.Set<T>().ToList<T>();
            }
            else
            {
                if (selectParam != null && selectParam.Where != null)
                    items = DataContext.Set<T>().Where(selectParam.Where).OrderBy(selectParam.OrderByString).Skip((int)(page - 1) * (int)size).Take((int)size).ToList<T>();
                else if (selectParam != null)
                    items = DataContext.Set<T>().OrderBy(selectParam.OrderByString).Skip((int)(page - 1) * (int)size).Take((int)size).ToList<T>();
                else
                    items = DataContext.Set<T>().Skip((int)(page - 1) * (int)size).Take((int)size).ToList<T>();
            }


            return items;
        }


        public virtual T Get(object id)
        {
            string fieldName = "";
            foreach (PropertyInfo prop in typeof(T).GetProperties())
            {
                if(prop.GetCustomAttributes(typeof(KeyAttribute), false)
                             .Cast<KeyAttribute>().FirstOrDefault() != null)
                {
                    fieldName = prop.Name;
                    break;
                }
            }
            IQueryable<T> result = DataContext.Set<T>().Where(fieldName + " = " + id);
            T o = result.FirstOrDefault<T>();

            return o;
        }

        public void Update(T instance)
        {
            object id = null;
            PropertyInfo keyProperty = null;
            foreach (PropertyInfo prop in instance.GetType().GetProperties())
            {
                if (prop.GetCustomAttributes(typeof(KeyAttribute), false)
                             .Cast<KeyAttribute>().FirstOrDefault() != null)
                {
                    id = prop.GetValue(instance, null);
                    keyProperty = prop;
                    break;
                }
            }
            if (id != null)
            {
                
                var entity = Get(id);
                if (entity != null)
                {
                    DataContext.Entry(entity).CurrentValues.SetValues(instance);
                    if (keyProperty != null)
                        DataContext.Entry(entity).Property(keyProperty.Name).IsModified = false;
                    DataContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Object doesn't exist", null);
                }
            }
            else
                throw new Exception("Object has no primary key value", null);
        }

    }
}
