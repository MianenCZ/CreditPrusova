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
    public class JStringTests
    {
      
        [TestMethod()]
        public void JStringFillTest()
        {
            JString s = new JString("test")
            { Value = "Value" };
            Assert.IsNotNull(s);
            Assert.AreEqual("test", s.Name);
            Assert.AreEqual("Value", s.Value);
            JString s2 = new JString("test2", "Value2");
            Assert.IsNotNull(s2);
            Assert.AreEqual("test2", s2.Name);
            Assert.AreEqual("Value2", s2.Value);

        }

        [TestMethod()]
        public void JStringToStringTest()
        {
            JString s = new JString("test")
            { Value = "Value" };
            Assert.IsNotNull(s);
            Assert.AreEqual("test", s.Name);
            Assert.AreEqual("Value", s.Value);
            Console.WriteLine(s.ToString(0));
            Assert.AreEqual("\"test\": \"Value\"", s.ToString(0));
        }

        [TestMethod()]
        public void JStringToStringPressedTest()
        {
            JString s = new JString("test")
            { Value = "Value" };
            Assert.IsNotNull(s);
            Assert.AreEqual("test", s.Name);
            Assert.AreEqual("Value", s.Value);
            Console.WriteLine(s.ToStringPressed());
            Assert.AreEqual("\"test\":\"Value\"", s.ToStringPressed());
            
        }
        [TestMethod()]
        public void JStringValueToStrinTest()
        {
            JString s = new JString("", "Value");
            Assert.IsNotNull(s);
            Console.WriteLine(s.ValueToString(0));
            Assert.AreEqual("\"Value\"", s.ValueToString(0));
        }

        /*
        //TODO: Read
        public void QuickestWayToReadAFile()
        {
            string data = System.IO.File.ReadAllText("FilePath");
            string[] dataArr = System.IO.File.ReadAllLines("FilePath");


            //Zákaz:
            string s = "";
            for (int i = 0; i < 150; i++)
            {
                s += "";
                s = s + "";
                //s[10] = 'a';

                s = s.Substring(0, 9) + s[10] + s.Substring(11);


            }


        }
        */


	}
}