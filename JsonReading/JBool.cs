using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReading
{
    public sealed class JBool : JObject
    {
        public override string Name { get; set; }

        public JBool(string Name) : base(Name)
        {
            this.Name = Name;
        }
        public JBool(string Name, Boolean Value) : base(Name)
        {
            this.Name = Name;
            this.Value = Value;
        }

        public Boolean Value { get; set; }

        public override string ToString(int tabs)
        {
            if (this.Value == true) //C# prints bools with first letter capital whereas Json uses small letters for bools
            {
                return $"\"{this.Name}\": true";
            }
            return $"\"{this.Name}\": false";
            
            }

        public override string ToStringPressed()
        {
            if (this.Value == true)
            {
                return $"\"{this.Name}\":true";
            }
            return $"\"{this.Name}\":false";
        }
        public override string ValueToString(int tabs)
        {
            if (this.Value == true)
            {
                return "true";
            }
            return "false";
        }
        public override string ValueToStringPressed()
        {
            if (this.Value == true)
            {
                return "true";
            }
            return "false";
        }
    }
}
