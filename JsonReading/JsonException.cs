using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReading
{
	public class JsonException : Exception
	{
		public JsonException() : base() { }

		public JsonException(string message) : base(message) { }

		public JsonException(string message, Exception innerException) 
			: base(message, innerException) { }

		public JsonException(System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context) 
			: base(info, context) { }
	}
    public class JsonRootException : JsonException
    {
        public JsonRootException(string message)  { }
    }
}
