using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("JsonNamelessTests")]
namespace JsonNameless
{
    public sealed class JToken : JObject //IDisposable
    {
        internal Dictionary<string, JObject> Children;

        internal override JRoot Root { get; set; }

        public int ChildrenCount { get => Children.Count; }

        public JObject this[string Key]
        {
            get
            {
                return Children[Key];
            }
            set
            {
                if (object.Equals(this.Root, null))
                    throw new JsonRootException("Root of array must be initialized before adding members to array");
                //TODO: JExp
                if (object.Equals(value, null))
                    throw new JsonNullException("Null cannot be assigned as a member of JToken");
                if (!(this.Root.CanBeAdded(value)))
                    throw new JsonDuplicatedException("This JsonTree already contains JObject you are trying to add and it cannot be added again.");
                Children[Key] = value;
                value.Root = this.Root;
                this.Root.AddToAnticycling(value);
            }
        }
        public JToken()
        {
            this.Children = new Dictionary<string, JObject>();
        }

        internal override void ToString(ref StringBuilder builder, int tabs)
        {
            builder.Append("{");
            bool oneLine = true;
            if (this.Children.Count < 10)
            {
                foreach (var item in this.Children)
                {
                    if ((item.Value is JToken) || (item.Value is JArray))
                    {
                        oneLine = false;
                    }
                }
            }
            else
            {
                oneLine = false;
            }

            if (oneLine)
            {
                int j = 0;
                foreach (var item in this.Children)
                {
                    builder.Append($"\"{item.Key}\": ");
                    item.Value.ToString(ref builder, tabs);
                    if (j < this.Children.Count - 1)
                    {
                        builder.Append(", ");
                    }
                    j++;
                }
            }
            else
            {
                tabs++;
                int k = 0;
                foreach (var item in this.Children)
                {
                    builder.Append("\n");
                    for (int j = 0; j < tabs; j++)
                    {
                        builder.Append("\t");
                    }
                    builder.Append($"\"{item.Key}\": ");
                    item.Value.ToString(ref builder, tabs);
                    if (k < this.Children.Count - 1)
                    {
                        builder.Append(",");
                    }
                    k++;
                }
                builder.Append("\n");
                tabs--;
                for (int j = 0; j < tabs; j++)
                {
                    builder.Append("\t");
                }
            }
            builder.Append("}");
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            this.ToString(ref builder, 0);
            return builder.ToString();
        }

        internal override void ToStringPressed(ref StringBuilder builder)
        {
            builder.Append("{");
            int j = 0;
            foreach (var item in this.Children)
            {
                builder.Append($"\"{item.Key}\":");
                item.Value.ToStringPressed(ref builder);
                if (j < this.Children.Count - 1)
                {
                    builder.Append(",");
                }
                j++;
            }
            builder.Append("}");
        }

        public override string ToStringPressed()
        {
            StringBuilder builder = new StringBuilder();
            this.ToStringPressed(ref builder);
            return builder.ToString();
        }
    }
}
