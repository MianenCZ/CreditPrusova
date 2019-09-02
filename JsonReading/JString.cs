using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReading
{
	public sealed class JString :	JObject
	{
		public override string Name { get; set; }

		internal override JRoot Root { get; set; }

		public JString(string Name) : base(Name)
		{
			this.Name = Name;
		}
        public JString(string Name, string Value) : base(Name)
        {
            this.Name = Name;
            this.Value = Value;
        }

		public string Value { get; set; }
		
		public override string ToString(int tabs)
		{
			return $"\"{this.Name}\": \"{this.Value}\"";
		}

		public override string ToStringPressed()
		{
			return $"\"{this.Name}\":\"{this.Value}\"";
		}

        public override string ValueToString(int tabs)
        {
            return $"\"{this.Value}\"";
        }
        public override string ValueToStringPressed()
        {
            return $"\"{this.Value}\"";
        }
    }
}
