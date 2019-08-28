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
    public class JNumberTests
    {
        [TestMethod()]
        public void JNumberFillTest()
        {
            JNumber s = new JNumber("test")
            { Value = 42 };
            Assert.IsNotNull(s);
            Assert.AreEqual(42, s.Value);
            Assert.AreEqual("test", s.Name);
            JNumber n = new JNumber("test2", 73);
            Assert.IsNotNull(n);
            Assert.AreEqual(73, n.Value);
            Assert.AreEqual("test2", n.Name);
        }
        [TestMethod()]
        public void JNumberToStringTest()
        {
            JNumber n = new JNumber("test")
            { Value = 42 };
            Assert.IsNotNull(n);
            Assert.AreEqual("test", n.Name);
            Assert.AreEqual(42, n.Value);
            Console.WriteLine(n.ToString());
            Assert.AreEqual("\"test\": 42", n.ToString(0));
            n.Value = 42.73;
            Assert.AreEqual(42.73, n.Value);
            Console.WriteLine(n.ToString());
            Assert.AreEqual("\"test\": 42.73", n.ToString(0));
        } 
        [TestMethod()]
        public void JNumberToStringPressedTest()
        {
            JNumber n = new JNumber("test")
            { Value = 42 };
            Assert.IsNotNull(n);
            Assert.AreEqual("test", n.Name);
            Assert.AreEqual(42, n.Value);
            Console.WriteLine(n.ToStringPressed());
            Assert.AreEqual("\"test\":42", n.ToStringPressed());
            n.Value = 42.73;
            Assert.AreEqual(42.73, n.Value);
            Console.WriteLine(n.ToStringPressed());
            Assert.AreEqual("\"test\":42.73", n.ToStringPressed());
        }
        [TestMethod()]
        public void JNumberValueToStrinTest()
        {
            JNumber n = new JNumber("", 42);
            Assert.IsNotNull(n);
            Console.WriteLine(n.ValueToString(0));
            Assert.AreEqual("42", n.ValueToString(0));
            n.Value = 42.73;
            Assert.AreEqual(42.73, n.Value);
            Console.WriteLine(n.ValueToString(0));
            Assert.AreEqual("42.73", n.ValueToString(0));
        }
    }
}
