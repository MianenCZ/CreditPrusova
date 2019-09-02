using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("JsonReadingTests")]
[assembly: InternalsVisibleTo("JsonReadingTests2")]
namespace JsonReading
{
	//TODO: Coments
	public class JRoot : JObject
	{
		public override string Name { get => "root"; set { } }
		internal override JRoot Root { get; set; }

		internal Dictionary<string, JObject> Items;

		//TODO: Exceptions
		public JObject this[string Key]
		{
			get {
				return Items[Key];
			}
			set {
				Items[Key] = value;
				value.Root = this;
			}
		}



		public JRoot() : base("root")
		{
			this.Items = new Dictionary<string, JObject>();
		}


		public override string ToString(int tabs)
		{
			throw new NotImplementedException();
		}

		public override string ToStringPressed()
		{
			throw new NotImplementedException();
		}

		public override string ValueToString(int tabs)
		{
			throw new NotImplementedException();
		}

		public override string ValueToStringPressed()
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			StringBuilder vld = new StringBuilder();

			vld.AppendLine("{");
			string Tabs = "\t";
			foreach (var item in Items)
			{
				vld.AppendLine($"{Tabs}\"{item.Key}\": \"{item.Value.ToString()}\"");
			}

			vld.AppendLine("}");

			return vld.ToString();
		}
	}
}
