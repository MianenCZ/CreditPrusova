using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonReading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReading.Tests
{
	[TestClass()]
	public class JTokenTests
	{
		[TestMethod()]
		public void JTokenFillTest()
		{
			JToken t = new JToken("test");
            Assert.IsNotNull(t);
            Assert.AreEqual("test", t.Name);
		}
        [TestMethod()]
        public void JTokenToStringPressedTest()
        {
			//TODO: object a is not used
            JArray a = new JArray("test");
            JNumber n = new JNumber("number", 7.3);
            JString s = new JString("string", "example");
            JBool b = new JBool("bool", true);
            JNull nu = new JNull("nil");
            JArray aa = new JArray("inside");
            JToken root = new JToken("root");
            JToken t = new JToken("token");
            JToken tt = new JToken("token2");
            aa.Value.Add(n);
            aa.Value.Add(b);
            tt.Value.Add(b);
            tt.Value.Add(nu);
            aa.Value.Add(tt);
            a.Value.Add(s);
            a.Value.Add(aa);
            a.Value.Add(n);
            t.Value.Add(aa);
            t.Value.Add(s);
            root.Value.Add(n);
            root.Value.Add(t);
            Console.WriteLine(root.ValueToStringPressed());
            Assert.AreEqual("{\"number\":7.3,\"token\":{\"inside\":[7.3,true,{\"bool\":true,\"nil\":null}],\"string\":\"example\"}}", root.ValueToStringPressed());
        }
        [TestMethod()]
        public void JTokenToStringTest()
        {
			//TODO: Why is possible to add a JToken into an array.
            JArray a = new JArray("test");
            JNumber n = new JNumber("number", 7.3);
            JString s = new JString("string", "example");
            JBool b = new JBool("bool", true);
            JNull nu = new JNull("nil");
            JArray aa = new JArray("inside");
            JToken root = new JToken("root");
            JToken t = new JToken("token");
            JToken tt = new JToken("token2");
            aa.Value.Add(n);
            aa.Value.Add(b);
            tt.Value.Add(b);
            tt.Value.Add(nu);
            aa.Value.Add(tt);
            a.Value.Add(s);
            a.Value.Add(aa);
            a.Value.Add(n);
            t.Value.Add(aa);
            t.Value.Add(s);
            root.Value.Add(n);
            root.Value.Add(t);
            Console.WriteLine(root.ValueToString(0));
            Assert.Fail();
        }
	}
}