using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Wiseape.Framework
{
    public class BaseValidator : IBaseFormValidator
    {

        public ValidationResult ValidateAdd(object o)
        {
            return new ValidationResult(true);
        }

        public ValidationResult ValidateDelete(object o)
        {
            return new ValidationResult(true);
        }

        public ValidationResult ValidateUpdate(object o)
        {
            return new ValidationResult(true);
        }
    }
}
