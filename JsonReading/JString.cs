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

		public JString(string Name) : base(Name)
		{
			this.Name = Name;
		}

		public string Value { get; set; }
		
		public override string ToString()
		{
			return $"\"{Name}\": \"{Value}\"";
		}

		public override string ToStringPressed()
		{
			return $"\"{Name}\":\"{Value}\"";
		}
	}
}
