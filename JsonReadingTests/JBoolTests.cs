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
    public class JBoolTests
    {
        [TestMethod()]
        public void JBooolFillTest()
        {
            JBool b = new JBool("test")
            { Value = true };
            Assert.IsNotNull(b);
            Assert.AreEqual("test", b.Name);
            Assert.AreEqual( true, b.Value);
            JBool b2 = new JBool("test2", false);
            Assert.IsNotNull(b2);
            Assert.AreEqual("test2", b2.Name);
            Assert.AreEqual(false, b2.Value);

        }
        [TestMethod()]
        public void JBoolToStringTest()
        {
            JBool b = new JBool("test")
            { Value = true };
            Assert.IsNotNull(b);
            Assert.AreEqual("test", b.Name);
            Assert.AreEqual(true, b.Value);
            Console.WriteLine(b.ToString());
            Assert.AreEqual("\"test\": true", b.ToString(0));
            b.Value = false;
            Console.WriteLine(b.ToString());
            Assert.AreEqual("\"test\": false", b.ToString(0));
        }
        [TestMethod()]
        public void JBoolToStringPressedTest()
        {
            JBool b = new JBool("test")
            { Value = true };
            Assert.IsNotNull(b);
            Assert.AreEqual("test", b.Name);
            Assert.AreEqual(true, b.Value);
            Console.WriteLine(b.ToString());
            Assert.AreEqual("\"test\":true", b.ToStringPressed());
            b.Value = false;
            Console.WriteLine(b.ToString());
            Assert.AreEqual("\"test\":false", b.ToStringPressed());

        }
        [TestMethod()]
        public void JBoolValueToStrinTest()
        {
            JBool t = new JBool("", true);
            Assert.IsNotNull(t);
            JBool f = new JBool("", false);
            Console.WriteLine(t.ValueToString(0));
            Assert.AreEqual("true", t.ValueToString(0));
            Console.WriteLine(f.ValueToString(0));
            Assert.AreEqual("false", f.ValueToString(0));

        }
    }
}
