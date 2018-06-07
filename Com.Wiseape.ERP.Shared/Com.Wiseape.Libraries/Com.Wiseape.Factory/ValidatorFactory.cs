using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Wiseape.Factory
{
    public class ValidatorFactory : BaseFactory
    {
        public static new object Create(string key)
        {
            AppSettingKey = "Factory.Validator.ConfigFile";
            return BaseFactory.Create(key);
        }
    }
}
