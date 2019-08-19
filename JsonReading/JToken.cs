using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReading
{
	public class JToken : JObject
	{
		public override string Name { get; set; }

		List<JObject> Children;

	}
}
