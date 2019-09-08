using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReading
{
    public sealed class JArray :JObject
    {
        public override string Name { get; set; }

        public JArray(string Name) : base(Name)
        {
            this.Name = Name;
            this.Value = new List<JObject>();
        }
        public List<JObject> Value;
 
        public override string ValueToStringPressed()
        {
            StringBuilder output = new StringBuilder("[");
            for (int i = 0; i < this.Value.Count; i++)
            {
                    output.Append(this.Value[i].ValueToStringPressed());
                    if (i < this.Value.Count - 1)
                    {
                        output.Append(",");
                    }               
            }
            output.Append("]");
            return output.ToString(); //StringBulider.ToSTring(); not my own method
        }

        public override string ToStringPressed()
        {
            StringBuilder output = new StringBuilder($"\"{this.Name}\":");
            output.Append(this.ValueToStringPressed());
            return output.ToString();
        }
        public override string ValueToString(int tabs)
        {           
            StringBuilder output = new StringBuilder("[");
            tabs++;
            for (int i = 0; i < this.Value.Count; i++)
            {
                output.Append("\n");
                for (int j = 0; j < tabs; j++)
                {
                    output.Append("\t");
                }
                output.Append(this.Value[i].ValueToString(tabs));
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
            output.Append(" ]");
            return output.ToString(); //StringBulider.ToSTring(); not my own method
        }


        public override string ToString(int tabs)
        {
            StringBuilder output = new StringBuilder($"\"{this.Name}\": ");
            output.Append(this.ValueToString(tabs));
            return output.ToString();
        }

    }
}
