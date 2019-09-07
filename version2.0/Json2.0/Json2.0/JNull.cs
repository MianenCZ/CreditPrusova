using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonNameless
{
    public sealed class JNull : JObject
    { 

        internal override JRoot Root { get; set; }

        public override string ToString()
        {
            return "null";
        }

        public override string ToStringPressed()
        {
            return "null";
        }

        internal override void ToString(ref StringBuilder builder, int tabs)
        {
            builder.Append("null");
        }

        internal override void ToStringPressed(ref StringBuilder builder)
        {
            builder.Append("null");
        }
    }
}
