using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReading
{
    public abstract class JObject
    {
        public abstract string Name { get; set; }

		internal abstract JRoot Root { get; set; }

        public JObject(string Name)
        {
            this.Name = Name;
        }

        public abstract string ToString(int tabs);

		public abstract string ToStringPressed();
        public abstract string ValueToString(int tabs);
        public abstract string ValueToStringPressed();
	}
}
