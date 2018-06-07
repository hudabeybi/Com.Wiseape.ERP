using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Wiseape.Framework
{
    public interface IFormValidator
    {
        ValidationResult Validate<T>(T form);
    }
}
