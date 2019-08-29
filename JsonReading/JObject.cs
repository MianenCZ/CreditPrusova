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

        public JObject(string Name)
        {
            this.Name = Name;
        }

        public abstract string ToString(int tabs);

		public abstract string ToStringPressed();
		//TODO: Why public?
        public abstract string ValueToString(int tabs);

		//TODO: Why public?
		public abstract string ValueToStringPressed();

		//TODO: Unreasonable missing of basic ToString()
		//public abstract string ToString();
	}
}
