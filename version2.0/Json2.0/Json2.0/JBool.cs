using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonNameless
{
    public sealed class JBool : JObject
    {
        public bool Value;

        internal override JRoot Root { get; set; }

        public JBool(bool Value)
        {
            this.Value = Value;
        }

        public override string ToString()
        {
            if (this.Value == true)
            {
                return "true";
            }
            return "false";
        }

        public override string ToStringPressed()
        {
            if (this.Value == true)
            {
                return "true";
            }
            return "false";
        }

        internal override void ToString(ref StringBuilder builder, int tabs)
        {
            if (this.Value == true)
            {
                builder.Append("true");
                return;
            }
            builder.Append("false");
        }

        internal override void ToStringPressed(ref StringBuilder builder)
        {
            if (this.Value == true)
            {
                builder.Append("true");
                return;
            }
            builder.Append("false");
        }
    }
}
