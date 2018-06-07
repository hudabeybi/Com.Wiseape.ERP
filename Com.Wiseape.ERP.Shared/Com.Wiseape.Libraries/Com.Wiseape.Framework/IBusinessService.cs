using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using Com.Wiseape.Utility;
using System.Linq.Expressions;

namespace Com.Wiseape.Framework
{
    public interface IBusinessService<T>
    {
        OperationResult FindAll(SelectParam selectParam, int? page, int? size);
        OperationResult FindAllByKeyword(SelectParam selectParam, int? page, int? size);
        OperationResult GetTotal(SelectParam selectParam);
        OperationResult Get(object id);
        OperationResult Add(T o);
        OperationResult Update(T o);
        OperationResult Delete(object o);
    }
}
