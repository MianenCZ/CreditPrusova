using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonNameless
{
    public class JArray : JObject
    {
        public List<JObject> Value;

        internal override JRoot Root { get; set; }

        public int ValuesCount { get => Value.Count; }

        //TODO: Constuktory z IEnumerable, IColection
        public JArray()
        {
            this.Value = new List<JObject>();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            this.ToString(ref builder,0);
            return builder.ToString();
        }

        public override string ToStringPressed()
        {
            StringBuilder builder = new StringBuilder();
            this.ToStringPressed(ref builder);
            return builder.ToString();
        }

        internal override void ToString(ref StringBuilder builder, int tabs)
        {
            builder.Append("[");
            int i = 0;
            bool oneLine=true;
            if (this.Value.Count > 10)
            {
                oneLine = false;
            }
            while ((i < this.Value.Count()) && (oneLine))
            {
                if ((this.Value[i] is JToken) ||(this.Value[i] is JArray))
                {
                    oneLine = false;
                }
                i++;
            }
            if (oneLine)
            {
                for (int j = 0; j < this.Value.Count; j++)
                {
                    this.Value[j].ToString(ref builder, tabs);
                    if (j < this.Value.Count - 1)
                    {
                        builder.Append(", ");
                    }
                }
            }
            else
            {
                tabs++;
                for (int k = 0; k < this.Value.Count; k++)
                {
                    builder.Append("\n");
                    for (int j = 0; j < tabs; j++)
                    {
                        builder.Append("\t");
                    }
                    this.Value[k].ToString(ref builder,tabs);
                    if (k < this.Value.Count - 1)
                    {
                        builder.Append(",");
                    }
                }
                builder.Append("\n");
                tabs--;
                for (int j = 0; j < tabs; j++)
                {
                    builder.Append("\t");
                }
              //  builder.Append(" ]");                
            }

            builder.Append("]");
            //TODO:bez tokenu, bez pole a pod 10 listu na radek, jinak pod sebe
        }

        internal override void ToStringPressed(ref StringBuilder builder)
        {
            builder.Append("[");
            for (int i = 0; i < this.Value.Count; i++)
            {
                this.Value[i].ToStringPressed(ref builder);
                if (i < this.Value.Count - 1)
                {
                    builder.Append(",");
                }
            }
            builder.Append("]");
        }
    }
}
