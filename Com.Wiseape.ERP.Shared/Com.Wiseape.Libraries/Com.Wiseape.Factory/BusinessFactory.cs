using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Reflection;


namespace Com.Wiseape.Factory
{

    public class BusinessFactory : BaseFactory
    {

        public static new object Create(string key)
        {
            AppSettingKey = "Factory.Business.ConfigFile";
            return BaseFactory.Create(key);
        }
    }
}
