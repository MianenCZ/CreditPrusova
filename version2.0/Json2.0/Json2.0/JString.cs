using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonNameless
{
    public sealed class JString : JObject
    {
        public string Value;

        internal override JRoot Root { get; set; }

        public JString(string Value)
        {
            this.Value = Value;          
        }

        internal override void ToString(ref StringBuilder builder, int tabs)
        {
            builder.Append($"{this.ToString()}");
        }

        public override string ToString()
        {
            return $"\"{Value.ToString()}\"";
        }

        internal override void ToStringPressed(ref StringBuilder builder)
        {
            builder.Append($"{this.ToString()}");
        }

        public override string ToStringPressed()
        {
            return $"\"{Value.ToString()}\"";
        }
        //TODO: zohlednit \n \" atd. pri nacitani Jstring
    }
}
