using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("JsonReadingTests")]
namespace JsonReading
{
	public class JToken : JObject
	{
		public override string Name { get; set; }
		
		public int ChildrenCount { get; set; }

		internal List<JObject> Children;

		public JToken(string Name) : base(Name)
		{
			this.Name = Name;
		}

		public override string ToStringPressed()
		{
			throw new NotImplementedException();
		}
	}
}
