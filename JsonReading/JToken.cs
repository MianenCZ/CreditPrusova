using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("JsonReadingTests")]
[assembly: InternalsVisibleTo("MianenTests")]
namespace JsonReading
{
	public class JToken : JObject
	{
		public override string Name { get; set; }
		
		public int ChildrenCount { get; set; }

		internal List<JObject> Value;

		public JToken(string Name) : base(Name)
		{
			this.Name = Name;
            this.Value = new List<JObject>();
		}

        public override string ValueToStringPressed()
        {
            StringBuilder output = new StringBuilder("{");
            for (int i = 0; i < this.Value.Count; i++)
            {
                output.Append(this.Value[i].ToStringPressed());
                if (i < this.Value.Count - 1)
                {
                    output.Append(",");
                }
            }
            output.Append("}");
            return output.ToString();
        }

        public override string ToStringPressed()
        {
            StringBuilder output = new StringBuilder($"\"{this.Name}\":");
            output.Append(this.ValueToStringPressed());
            return output.ToString();
        }

		//TODO: Private VS Public
        public override string ValueToString(int tabs)
        {
            StringBuilder output = new StringBuilder("{");
            tabs++;
            for (int i = 0; i < this.Value.Count; i++)
            {
                output.Append("\n");
                for (int j = 0; j < tabs; j++)
                {
                    output.Append("\t");
                }
                output.Append(this.Value[i].ToString(tabs));
                if (i < this.Value.Count - 1)
                {
                    output.Append(",");
                }
            }
            output.Append("\n");
            tabs--;
            for (int j = 0; j < tabs; j++)
            {
                output.Append("\t");
            }
            output.Append("}");
            return output.ToString();
        }

        public override string ToString(int tabs)
        {
            StringBuilder output = new StringBuilder($"\"{this.Name}\": ");
            output.Append(this.ValueToString(tabs));
            return output.ToString();
        }

        
       
    }
}
