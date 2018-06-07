using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Wiseape.Utility;

namespace Com.Wiseape.Utility.HttpUtility
{
    public class HttpParameterListProcessor : Com.Wiseape.Utility.ListUtility.IListProcessor
    {
        public string Process(IDictionary<string, object> list)
        {
            string sList = "";
            foreach(KeyValuePair<string, object > entry in list)
            {
                sList += entry.Key + "=" + entry.Value + "&";
            }
            if (sList.Length > 0)
                sList = sList.Substring(0, sList.Length - 1);
            return sList;
        }
    }
}
