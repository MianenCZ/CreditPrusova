using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReading
{
    public sealed class JNull : JObject
    {
        public override string Name { get; set; }

        public JNull(string Name) : base(Name)
        {
            this.Name = Name;
        }
       
        public override string ToString(int tabs)
        {
            return $"\"{this.Name}\": null";
        }

        public override string ToStringPressed()
        {
            return $"\"{this.Name}\":null";
        }
        public override string ValueToString(int tabs)
        {
            return "null";
        }
        public override string ValueToStringPressed()
        {
            return "null";
        }
    }
}
