using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace JsonNameless
{
    public sealed class JNumber : JObject
    {
        public double Value;

        internal override JRoot Root { get; set; }

        public JNumber(double Value)
        {
            this.Value = Value;
        }

        internal override void ToString(ref StringBuilder builder, int tabs)
        {
            builder.Append(this.ToString());
        }

        public override string ToString()
        {
            CultureInfo us = new CultureInfo("us");
            return this.Value.ToString(us);
        }

        internal override void ToStringPressed(ref StringBuilder builder)
        {
            builder.Append(this.ToString());
        }

        public override string ToStringPressed()
        {
            CultureInfo us = new CultureInfo("us");
            return this.Value.ToString(us);
        }
    }
}
