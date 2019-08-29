using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonReading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReadingTests
{
    [TestClass()]
    public class JArrayTests
    {
        [TestMethod()]
        public void JArrayValueToStringPressedTest()
        {
            JArray a = new JArray("test");
            JNumber n = new JNumber("cislo", 42);
            JString s = new JString("string", "pokus");
            JBool b = new JBool("bool", true);
            JNull nu = new JNull("nil");
            //Jobject o = ...
            a.Value.Add(n);
            a.Value.Add(s);
            a.Value.Add(b);
            a.Value.Add(nu);
            JArray aa = new JArray("inside");
            aa.Value.Add(nu);
            aa.Value.Add(b);
            a.Value.Add(aa);
            Console.WriteLine(a.ValueToStringPressed());
            Assert.IsNotNull(a);
            Assert.AreEqual("[42,\"pokus\",true,null,[null,true]]", a.ValueToStringPressed());
        }

        [TestMethod()]
        public void JArrayToStringPressedTest()
        {
            JArray a = new JArray("test");
            JNumber n = new JNumber("cislo", 42);
            JString s = new JString("string", "pokus");
            JBool b = new JBool("bool", true);
            JNull nu = new JNull("nil");
            a.Value.Add(n);
            a.Value.Add(s);
            a.Value.Add(b);
            a.Value.Add(nu);
            JArray aa = new JArray("inside");
            aa.Value.Add(nu);
            aa.Value.Add(b);
            a.Value.Add(aa);
            Console.WriteLine(a.ToStringPressed());
            Assert.IsNotNull(a);
            Assert.AreEqual("\"test\":[42,\"pokus\",true,null,[null,true]]", a.ToStringPressed());




        }
        [TestMethod()]
        public void JArrayValueToStringTest()
        {
            JArray a = new JArray("test");
            JNumber n = new JNumber("cislo", 42);
            JString s = new JString("string", "pokus");
            JBool b = new JBool("bool", true);
            JNull nu = new JNull("nil");
            JArray aa = new JArray("inside");
            a.Value.Add(nu);
            a.Value.Add(b);
            a.Value.Add(s);
            aa.Value.Add(n);
            aa.Value.Add(s);
            a.Value.Add(aa);
            Assert.IsNotNull(a);
            Console.WriteLine(a.ValueToString(0));
            Assert.AreEqual("[\n\tnull,\n\ttrue,\n\t\"pokus\",\n\t[\n\t\t42,\n\t\t\"pokus\"\n\t]\n]", a.ValueToString(0));
        }
        [TestMethod()]
        public void JArrayToStringTest()
        {
            JArray a = new JArray("test");
            JNumber n = new JNumber("cislo", 42);
            JString s = new JString("string", "pokus");
            JBool b = new JBool("bool", true);
            JNull nu = new JNull("nil");
            JArray aa = new JArray("inside");
            a.Value.Add(nu);
            a.Value.Add(b);
            a.Value.Add(s);
            aa.Value.Add(n);
            aa.Value.Add(s);
            a.Value.Add(aa);
            Assert.IsNotNull(a);
            Console.WriteLine(a.ToString(0));
            Assert.AreEqual("\"test\": [\n\tnull,\n\ttrue,\n\t\"pokus\",\n\t[\n\t\t42,\n\t\t\"pokus\"\n\t]\n]", a.ToString(0));
        }
      
    }
}
