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
    public class JStringTests
    {

        [TestMethod()]
        public void JStringFillTest()
        {
            JString s = new JString("Value");
            Assert.IsNotNull(s);
            Assert.AreEqual("Value", s.Value);
           
        }

        [TestMethod()]
        public void JStringToStringTest()
        {
            JString s = new JString("Value");
            Assert.IsNotNull(s);
            Assert.AreEqual("Value", s.Value);
            Console.WriteLine(s.ToString());
            Assert.AreEqual("\"Value\"", s.ToString());
            
            
        }

        [TestMethod()]
        public void JStringToStringPressedTest()
        {
            JString s = new JString("Value");
            Assert.IsNotNull(s);
            Assert.AreEqual("Value", s.Value);
            Console.WriteLine(s.ToString());
            Assert.AreEqual("\"Value\"", s.ToString());
            

        }
  

    }
    }
