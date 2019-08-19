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

		public JObject()
		{

		}
	
		public override string ToString()
		{
			return base.ToString();
		}

	}
}
