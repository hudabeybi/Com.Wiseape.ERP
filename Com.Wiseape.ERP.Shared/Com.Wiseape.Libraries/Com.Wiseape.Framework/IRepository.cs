using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Com.Wiseape.Framework
{
    public interface IRepository<T>
    {
        void Add(object instance);
        T Get(object id);
        void Delete(object id);
        void Update(T instance);
        List<T> FindAll(SelectParam selectParam, int? page, int? size) ;
        Int64 GetTotal(SelectParam selectParam);
    }
}
