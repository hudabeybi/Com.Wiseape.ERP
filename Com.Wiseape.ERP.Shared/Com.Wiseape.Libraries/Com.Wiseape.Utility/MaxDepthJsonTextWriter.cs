using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Wiseape.Utility
{
    public class MaxDepthJsonTextWriter : JsonTextWriter
    {
        public int? MaxDepth { get; set; }
        public int MaxObservedDepth { get; private set; }

        public MaxDepthJsonTextWriter(TextWriter writer, JsonSerializerSettings settings)
            : base(writer)
        {
            this.MaxDepth = (settings == null ? null : settings.MaxDepth);
            this.MaxObservedDepth = 0;
        }

        public MaxDepthJsonTextWriter(TextWriter writer, int? maxDepth)
            : base(writer)
        {
            this.MaxDepth = maxDepth;
        }

        public override void WriteStartArray()
        {
            if(CheckDepth())
               base.WriteStartArray();
            //CheckDepth();
        }

        public override void WriteStartConstructor(string name)
        {
            if (CheckDepth())
                base.WriteStartConstructor(name);
            //CheckDepth();
        }

        public override void WriteStartObject()
        {
            if (CheckDepth())
                base.WriteStartObject();
            //CheckDepth();
        }

        private bool CheckDepth()
        {
            MaxObservedDepth = Math.Max(MaxObservedDepth, Top);
            if (Top > MaxDepth)
                return false;
            else
                return true;
            
            //throw new JsonSerializationException(string.Format("Depth {0} Exceeds MaxDepth {1} at path \"{2}\"", Top, MaxDepth, Path));
        }
    }
}
