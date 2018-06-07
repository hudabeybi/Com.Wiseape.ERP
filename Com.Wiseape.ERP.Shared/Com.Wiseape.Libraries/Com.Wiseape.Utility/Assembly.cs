using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Com.Wiseape.Utility
{
    public class Assembly
    {
        public static Dictionary<string, System.Reflection.Assembly> assmeblies = new Dictionary<string, System.Reflection.Assembly>();
        public static object LoadObject(string filename, string className)
        {
            System.Reflection.Assembly asm = null;
            if (assmeblies.ContainsKey(filename))
                asm = assmeblies[filename];
            else
            {
                asm = System.Reflection.Assembly.LoadFrom(filename);
                assmeblies.Add(filename, asm);
            }
            var type = asm.GetType(className);
            object o = Activator.CreateInstance(type);
            return o;
        }

        public static PropertyInfo GetKeyProperty(Type type)
        {
            foreach(PropertyInfo prop in type.GetProperties())
            {
                KeyAttribute keyAttribute = type.GetProperty(prop.Name).GetCustomAttributes(typeof(KeyAttribute), false).Cast<KeyAttribute>().Single();
                if (keyAttribute != null)
                    return prop;
            }

            return null;
        }
    }
}
