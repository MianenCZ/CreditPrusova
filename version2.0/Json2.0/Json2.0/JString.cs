using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonNameless
{
    /// <summary>
    /// Represents a part of Json containing string value 
    /// </summary>
    public sealed class JString : JObject
    {
        public string Value;

        internal override JRoot Root { get; set; }
        /// <summary>
        /// Initializes a new instance of JString with given string Value
        /// </summary>
        /// <param name="Value"></param>
        public JString(string Value)
        {

            this.Value = Value;

        }

        internal override void ToString(ref StringBuilder builder, int tabs)
        {
            builder.Append($"{this.ToString()}");
        }
        /// <summary>
        /// Returns string value of this instance of JString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"\"{Value.ToString()}\"";
        }

        internal override void ToStringPressed(ref StringBuilder builder)
        {
            builder.Append($"{this.ToString()}");
        }
        /// <summary>
        /// Returns string value of this instance of JString
        /// </summary>
        /// <returns></returns>
        public override string ToStringPressed()
        {
            return $"\"{Value.ToString()}\"";
        }
        //TODO: zohlednit \n \" atd. pri nacitani Jstring
    }
}
