using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonNameless
{
    public abstract class JObject
    {

        internal abstract JRoot Root { get; set; }

        internal abstract void ToString(ref StringBuilder builder, int tabs);

        public abstract new string ToString();

        internal abstract void ToStringPressed(ref StringBuilder builder);

        public abstract string ToStringPressed();

    }
}
