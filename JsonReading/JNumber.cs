using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace JsonReading
{
    public sealed class JNumber : JObject
    {
        public override string Name { get; set; }

		internal override JRoot Root { get; set; }

		public JNumber(double Value) : base("")
		{
			this.Value = Value;
		}

        public JNumber(string Name) : base(Name)
        {
            this.Name = Name;
        }
        public JNumber(string Name, double Value) : base(Name)
        {
            this.Name = Name;
            this.Value = Value;
        }
        public double Value { get; set; }

        public override string ToString(int tabs)
        {
            NumberFormatInfo nfi = new NumberFormatInfo
            {
                NumberDecimalSeparator = "."
            };
            string value = this.Value.ToString(nfi);
            return $"\"{this.Name}\": {value}";
        }

        public override string ToStringPressed()
        {
            NumberFormatInfo nfi = new NumberFormatInfo
            {
                NumberDecimalSeparator = "."
            };
            string value = this.Value.ToString(nfi);
            return $"\"{this.Name}\":{value}";
        }

        public override string ValueToString(int tabs)
        {
            NumberFormatInfo nfi = new NumberFormatInfo
            {
                NumberDecimalSeparator = "."
            };
            string value = this.Value.ToString(nfi);
            return value;
        }
        public override string ValueToStringPressed()
        {
            NumberFormatInfo nfi = new NumberFormatInfo
            {
                NumberDecimalSeparator = "."
            };
            string value = this.Value.ToString(nfi);
            return value;
        }

		public override string ToString()
		{
			return Value.ToString();
		}
	}

}

