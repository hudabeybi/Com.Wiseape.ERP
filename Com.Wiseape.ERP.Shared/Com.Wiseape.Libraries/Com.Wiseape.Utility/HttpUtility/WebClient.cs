using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Wiseape.Utility;
using System.Net;

namespace Com.Wiseape.Utility.HttpUtility
{

    public class WebClient
    {
        protected static string ConvertParameter(ListUtility.Parameters parameters)
        {
            HttpParameterListProcessor httpParameterListProcessor = new HttpParameterListProcessor();
            string sParameters = parameters.Convert(httpParameterListProcessor);
            return sParameters;
        }

        public static string Post(string url, ListUtility.Parameters parameters)
        {
            string sParameters = ConvertParameter(parameters);
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string HtmlResult = wc.UploadString(url, sParameters);
            return HtmlResult;
        }

        public static string Post(string url, string json)
        {
            string sParameters = json;
            System.Net.WebClient wc = new System.Net.WebClient();
            wc.Headers[HttpRequestHeader.ContentType] = "application/json";
            string HtmlResult = wc.UploadString(url, sParameters);
            return HtmlResult;
        }

        public static string Get(string url, ListUtility.Parameters parameters)
        {
            string sParameters = ConvertParameter(parameters);
            System.Net.WebClient wc = new System.Net.WebClient();
            string htmlResult = wc.DownloadString(url + "?" + sParameters);
            return htmlResult;
        }
    }
}
