using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.Framework
{
    public interface IBaseFormValidator
    {
        ValidationResult ValidateAdd(object o);
        ValidationResult ValidateUpdate(object o);
        ValidationResult ValidateDelete(object o);
    }
}
