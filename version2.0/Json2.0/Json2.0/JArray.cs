using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonNameless
{
    public class JArray : JObject //IDisposable
    {
        internal List<JObject> Value;

        internal override JRoot Root { get; set; }

        public int ValuesCount { get => Value.Count; }

        public JObject this[int Key]
        {
            get
            {
                return Value[Key];
            }
            set
            {
                if (object.Equals(this.Root, null))
                      throw new JsonRootException("Root of array must be initialized before adding members to array");
                //TODO: JExp
                if (object.Equals(value, null))
                    throw new JsonNullException("Null cannot be assigned as a member of JArray");
                if (!(this.Root.CanBeAdded(value)))
                    throw new JsonDuplicatedException("This JsonTree already contains JObject you are trying to add and it cannot be added again.");
                Value[Key] = value;
                value.Root = this.Root;
                this.Root.AddToAnticycling(value);
            }
        }
        public JArray()
        {
            this.Value = new List<JObject>();
        }

        public JArray(IEnumerable<JObject> collection)
        {
            this.Value = new List<JObject>();
            this.Value.AddRange(collection);
        }

        public void Add(JObject ItemToAdd)
        {
            if (object.Equals(this.Root, null))
                throw new JsonRootException("Root of array must be initialized before adding members to array");
            if (object.Equals(ItemToAdd, null))
                throw new JsonNullException("Null cannot be assigned as a member of JArray");
            if (!(this.Root.CanBeAdded(ItemToAdd)))
                throw new JsonDuplicatedException("This JsonTree already contains JObject you are trying to add and it cannot be added again.");
            ItemToAdd.Root = this.Root;
            this.Value.Add(ItemToAdd);
            this.Root.AddToAnticycling(ItemToAdd);
        }

        public void AddOnIndex(int Index, JObject ItemToAdd)
        {
            if (object.Equals(this.Root, null))
                throw new JsonRootException("Root of array must be initialized before adding members to array");
            if (object.Equals(ItemToAdd, null))
                throw new JsonNullException("Null cannot be assigned as a member of JArray");
            if (!(this.Root.CanBeAdded(ItemToAdd)))
                throw new JsonDuplicatedException("This JsonTree already contains JObject you are trying to add and it cannot be added again.");
            ItemToAdd.Root = this.Root;
            this.Value.Insert(Index, ItemToAdd);
            this.Root.AddToAnticycling(ItemToAdd);
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
