using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace JsonNameless
{
    /// <summary>
    /// Represents a part of Json containing numeric Value
    /// </summary>
    public sealed class JNumber : JObject
    {
        public double Value;

        internal override JRoot Root { get; set; }
        /// <summary>
        /// Initializes a new instance of JNumber with given double Value
        /// </summary>
        /// <param name="Value"></param>
        public JNumber(double Value)
        {
            this.Value = Value;
        }

        internal override void ToString(ref StringBuilder builder, int tabs)
        {
            builder.Append(this.ToString());
        }
        /// <summary>
        /// Converts numeric value of this instance of JNumber to equivalent string representation
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            CultureInfo us = new CultureInfo("us");
            return this.Value.ToString(us);
        }

        internal override void ToStringPressed(ref StringBuilder builder)
        {
            builder.Append(this.ToString());
        }
        /// <summary>
        /// Converts numeric value of this instance of JNumber to equivalent string representation
        /// </summary>
        /// <returns></returns>
        public override string ToStringPressed()
        {
            CultureInfo us = new CultureInfo("us");
            return this.Value.ToString(us);
        }
    }
}
