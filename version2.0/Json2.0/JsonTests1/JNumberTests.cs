using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonNameless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonNamelessTests
{
    [TestClass()]
    public class JNumberTests
    {
        [TestMethod()]
        public void JNumberFillTest()
        {
            JNumber s = new JNumber(42);
            Assert.IsNotNull(s);
            Assert.AreEqual(42, s.Value);
            JNumber n = new JNumber(7.3);
            Assert.IsNotNull(n);
            Assert.AreEqual(7.3, n.Value);
            JNumber m = new JNumber(3.14e+12);
            Assert.IsNotNull(m);
            Assert.AreEqual(3.14e+12, m.Value);
        }
        [TestMethod()]
        public void JNumberToStringTest()
        {
            JNumber n = new JNumber(42);
            Assert.IsNotNull(n);
            Assert.AreEqual(42, n.Value);
            Console.WriteLine(n.ToString());
            Assert.AreEqual("42", n.ToString());
            n.Value = 42.73;
            Assert.AreEqual(42.73, n.Value);
            Console.WriteLine(n.ToString());
            Assert.AreEqual("42.73", n.ToString());
            n.Value = 3.14e+17;
            Assert.AreEqual(3.14e+17, n.Value);
            Console.WriteLine(n.ToString());
            Assert.AreEqual("3.14E+17", n.ToString());

        }
        [TestMethod()]
        public void JNumberToStringPressedTest()
        {
            JNumber n = new JNumber(42);
            Assert.IsNotNull(n);
            Assert.AreEqual(42, n.Value);
            Console.WriteLine(n.ToStringPressed());
            Assert.AreEqual("42", n.ToStringPressed());
            n.Value = 42.73;
            Assert.AreEqual(42.73, n.Value);
            Console.WriteLine(n.ToString());
            Assert.AreEqual("42.73", n.ToStringPressed());
            n.Value = 3.14e12;
            Assert.AreEqual(3.14e12, n.Value);
            Console.WriteLine(n.ToStringPressed());
            Assert.AreEqual("3.14e12", n.ToStringPressed());

        }
    }
}
