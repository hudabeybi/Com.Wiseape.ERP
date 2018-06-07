using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;

namespace Com.Wiseape.Utility
{
    public class OperationResult
    {
        
        public System.String Message { get; set; }
        public bool Result { get; set; }
        public object Data { get; set; }

        public OperationResult()
        {

        }

        public OperationResult(bool result) : this(result, null, "")
        {

        }

        public OperationResult(bool result, object data) : this(result, data, null)
        {

        }

        public OperationResult(bool result, string message) : this(result, null, message)
        {

        }



        public OperationResult(bool result, object data, string message)
        {
            this.Message = message;
            this.Result = result;
            this.Data = data;
        }

        public Stream ToJsonStream()
        {
            string jsonString = Serializer.Json.Serialize(this);
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
        }
    }
}
