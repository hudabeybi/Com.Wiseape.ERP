using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Hosting;

namespace Com.Wiseape.Factory
{
    public class FactoryNoConfigurationException : Exception
    {
        public string Key { get; set; }
        public FactoryNoConfigurationException(string key) : base("Factory Error: The configuration doesn't exist for key '" + key + "'")
        {
            this.Key = key;
        }
    }

    public class BaseFactory
    {
        protected static string AppSettingKey;
        public static string LibraryPath
        {
            get
            {
                return ConfigurationManager.AppSettings["Factory.LibraryPath"].ToString();
            }
        }

        public static string CofigurationFile
        {
            get
            {
                return ConfigurationManager.AppSettings[AppSettingKey].ToString();
            }
        }


        protected static List<FactoryConfigurationItem> GetConfigurationItems()
        {
            string path = HostingEnvironment.MapPath("~/" + BaseFactory.CofigurationFile);
            string xmlContent = System.IO.File.ReadAllText( path );
            List<FactoryConfigurationItem> items = Com.Wiseape.Utility.Serializer.XML.Deserialize<List<FactoryConfigurationItem>>(xmlContent);
            return items;
        }

        protected static FactoryConfigurationItem GetFactoryConfigurationByKey(string key)
        {
            List<FactoryConfigurationItem> items = GetConfigurationItems();
            foreach (FactoryConfigurationItem item in items)
            {
                if (item.Key.ToLower().Equals(key.ToLower()))
                    return item;
            }

            return null;

        }
        public static object Create(string key)
        {
            FactoryConfigurationItem item = GetFactoryConfigurationByKey(key);

            if (item == null)
                throw new FactoryNoConfigurationException(key);
            string dllFile = BaseFactory.LibraryPath + "\\" + item.DllName;
            string className = item.ClassName;
            string path = HostingEnvironment.MapPath("~/" + dllFile);
            object obj = Com.Wiseape.Utility.Assembly.LoadObject(path, className);
            return obj;
        }
    }
}
