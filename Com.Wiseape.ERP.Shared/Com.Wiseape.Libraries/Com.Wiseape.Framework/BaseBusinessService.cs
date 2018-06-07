using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Data.Entity;
using Com.Wiseape.Utility;
using Com.Wiseape.Framework;
using System.Linq.Expressions;

namespace Com.Wiseape.Framework
{
    public abstract class BaseBusinessService<T>  : IBusinessService<T>
    {
        protected string RepoKey
        {
            set;
            get;
        }
        private IRepository<T> repo;
        protected IRepository<T> Repository
        {
            get
            {
                if(repo == null)
                    repo = (IRepository<T>)Com.Wiseape.Factory.RepositoryFactory.Create(RepoKey);
                return repo;
            }
        }

        public BaseBusinessService()
        {
        }

        public BaseBusinessService(string repoKey)
        {
            repo = (IRepository<T>)Com.Wiseape.Factory.Factory.CreateRepositoryService<T>(repoKey);
        }

        protected IRepository<T2> CreateRepository<T2>(string key)
        {
            IRepository<T2> repo = (IRepository<T2>)Com.Wiseape.Factory.Factory.CreateRepositoryService<T2>(key);
            return repo;
        }

        public virtual OperationResult FindAll(SelectParam selectParam, int? page, int? size)
        {
            if (page == 0)
                page = null;

            if (size == 0)
                size = null;
            try
            {
                selectParam = this.SetAdditionalParameter(selectParam);
                if (selectParam.Where == "")
                    selectParam.Where = null;
                List<T> items = Repository.FindAll(selectParam, page, size);
                return new OperationResult(true, items);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e, e.Message);
            }
        }

        public virtual OperationResult FindAllByKeyword(SelectParam selectParam, int? page, int? size)
        {
            string where = GetPredicateByKeyword(selectParam.Keyword);
            selectParam.Where = where;
            return this.FindAll(selectParam, page, size);
        }

        protected virtual String GetPredicateByKeyword(string keyword)
        {
            return keyword;
        }

        protected virtual SelectParam SetAdditionalParameter(SelectParam selectParam)
        {
            return selectParam;
        }

        public virtual OperationResult Get(object id)
        {
            T o = default(T);
            try
            {
                o = Repository.Get(id);
                return new OperationResult(true, o);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e, e.Message);
            }
        }


        public virtual OperationResult Add(T o)
        {
            ValidationResult validationResult = new ValidationResult(true);
            IBaseFormValidator validator = null;
            try
            {
                validator = (IBaseFormValidator)Com.Wiseape.Factory.ValidatorFactory.Create(this.RepoKey);
                validationResult = validator.ValidateAdd(o);
            }
            catch
            {

            }
            try
            {
                if (validationResult.Result)
                {
                    Repository.Add(o);
                    return new OperationResult(true, o);
                }
                else
                {
                    return new OperationResult(false, validationResult);
                }
            }
            catch (Exception e)
            {
                return new OperationResult(false, e, e.Message);
            }
        }

        public virtual OperationResult Update(T o)
        {
            ValidationResult validationResult = new ValidationResult(true);
            IBaseFormValidator validator = null;
            try
            {
                validator = (IBaseFormValidator)Com.Wiseape.Factory.ValidatorFactory.Create(this.RepoKey);
                validationResult = validator.ValidateUpdate(o);
            }
            catch
            {

            }
            try
            {
                if (validationResult.Result)
                {
                    Repository.Update(o);
                    return new OperationResult(true, o);
                }
                else
                {
                    return new OperationResult(false, validationResult);
                }
            }
            catch (Exception e)
            {
                return new OperationResult(false, e, e.Message);
            }
        }

        public virtual OperationResult Delete(object o)
        {
            ValidationResult validationResult = new ValidationResult(true);
            IBaseFormValidator validator = null;
            try
            {
                validator = (IBaseFormValidator)Com.Wiseape.Factory.ValidatorFactory.Create(this.RepoKey);
                validationResult = validator.ValidateDelete(o);
            }
            catch
            {

            }
            try
            {
                if (validationResult.Result)
                {
                    Repository.Delete(o);
                    return new OperationResult(true, o);
                }
                else
                {
                    return new OperationResult(false, validationResult);
                }
            }
            catch (Exception e)
            {
                return new OperationResult(false, e, e.Message);
            }
        }

        public virtual OperationResult GetTotal(SelectParam selectParam)
        {
            try
            {
                Int64 total = Repository.GetTotal(selectParam);
                return new OperationResult(true, total);
            }
            catch (Exception e)
            {
                return new OperationResult(false, e, e.Message);
            }
        }
    }
}
