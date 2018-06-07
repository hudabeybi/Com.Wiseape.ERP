using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Com.Wiseape.Factory
{
    public class Factory
    {
        protected static string GetAssemblyPath()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }

        protected static string GetViewConfigPath()
        {
            string filename = System.Configuration.ConfigurationManager.AppSettings["Factory.View.ConfigFile"];
            return filename;
        }

        protected static string GetBusinessConfigPath()
        {
            string filename = System.Configuration.ConfigurationManager.AppSettings["Factory.Business.ConfigFile"];
            return filename;
        }

        protected static string GetRepositoryConfigPath()
        {
            string filename = System.Configuration.ConfigurationManager.AppSettings["Factory.Repository.ConfigFile"];
            return filename;
        }

        protected static string GetDataContextConfigPath()
        {
            string filename = System.Configuration.ConfigurationManager.AppSettings["Factory.DataContext.ConfigFile"];
            return filename;
        }

        protected static List<FactoryConfigurationItem> GetFactoryConfigurationItemList(string filename)
        {
            string xml = System.IO.File.ReadAllText(filename);
            List<FactoryConfigurationItem> items = Utility.Serializer.XML.Deserialize<List<FactoryConfigurationItem>>(xml);
            return items;
        }

        protected static FactoryConfigurationItem GetFactoryConfirationItemByKey(string filename, string key)
        {
            List<FactoryConfigurationItem> list = GetFactoryConfigurationItemList(filename);
            foreach(FactoryConfigurationItem item in list)
            {
                if(item.Key.ToLower().Equals(key))
                {
                    return item;
                }
            }
            return null;
        }

        public static T CreateBusinessService<T>(string key)
        {
            string filename = GetAssemblyPath() + GetBusinessConfigPath();
            FactoryConfigurationItem item = GetFactoryConfirationItemByKey(filename, key);

            if(item != null)
            {
                T dllObject = (T)Com.Wiseape.Utility.Assembly.LoadObject(filename, item.ClassName);
                return dllObject;
            }
            
            return default(T);
        }

        public static T CreateViewService<T>(string key)
        {
            string filename = GetAssemblyPath() + GetViewConfigPath();
            FactoryConfigurationItem item = GetFactoryConfirationItemByKey(filename, key);

            if (item != null)
            {
                T dllObject = (T)Com.Wiseape.Utility.Assembly.LoadObject(filename, item.ClassName);
                return dllObject;
            }

            return default(T);
        }

        public static T CreateRepositoryService<T>(string key)
        {
            string filename = GetAssemblyPath() + GetRepositoryConfigPath();
            FactoryConfigurationItem item = GetFactoryConfirationItemByKey(filename, key);

            if (item != null)
            {
                T dllObject = (T)Com.Wiseape.Utility.Assembly.LoadObject(filename, item.ClassName);
                return dllObject;
            }

            return default(T);
        }

        public static  T CreateDataContext<T>(string key)
        {
            string filename = GetAssemblyPath() + GetRepositoryConfigPath();
            FactoryConfigurationItem item = GetFactoryConfirationItemByKey(filename, key);

            if (item != null)
            {
                T dllObject = (T)Com.Wiseape.Utility.Assembly.LoadObject(filename, item.ClassName);
                return dllObject;
            }

            return default(T);
        }
    }
}
