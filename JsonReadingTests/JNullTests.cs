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
    public class JNullTests
    {
        [TestMethod()]
        public void JNullFillTest()
        {
            JNull n = new JNull("test");
            Assert.IsNotNull(n);
            Assert.AreEqual("test", n.Name);        
        }
        [TestMethod()]
        public void JNumberToStringTest()
        {
            JNull n = new JNull("test");
            Assert.IsNotNull(n);
            Assert.AreEqual("test", n.Name);
            Console.WriteLine(n.ToString(0));
            Assert.AreEqual("\"test\": null", n.ToString(0));
        }
        [TestMethod()]
        public void JNumberToStringPressedTest()
        {
            JNull n = new JNull("test");
            Assert.IsNotNull(n);
            Assert.AreEqual("test", n.Name);
            Console.WriteLine(n.ToString());
            Assert.AreEqual("\"test\":null", n.ToStringPressed());
        }
        [TestMethod()]
        public void JNullValueToStrinTest()
        {
            JNull n = new JNull("");
            Assert.IsNotNull(n);
            Console.WriteLine(n.ValueToString(0));
            Assert.AreEqual("null", n.ValueToString(0));
        }
    }
}
