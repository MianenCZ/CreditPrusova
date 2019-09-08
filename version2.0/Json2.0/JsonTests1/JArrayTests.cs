using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonNameless;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonNamelessTests
{
    [TestClass]
    public class JArrayTests
    {
        [TestMethod()]
        public void JArrarEnumerableConstructor()
        {
            List<JNumber> num = new List<JNumber>();
            for (int i = 0; i < 10; i++)
            {
                num.Add(new JNumber(i));
            }
            JArray a = new JArray(num);
            Console.WriteLine(a.ToString());
            Assert.AreEqual("[0, 1, 2, 3, 4, 5, 6, 7, 8, 9]", a.ToString());
        }
        [TestMethod()]
        public void JArrayToStringPressedTest()
        {
            JArray a = new JArray();
            JNumber n = new JNumber(42);
            JNumber n2 = new JNumber(7.3);
            JString s = new JString("pokus");
            JString s2 = new JString("pokus2");
            JBool b = new JBool(true);
            JBool b2 = new JBool(false);
            JNull nu = new JNull();
            JNull nu2 = new JNull();
            JNull nu3 = new JNull();
            JToken t = new JToken();
            JRoot root = new JRoot();
            root["pole"] = a;
            a.Add(n);
            a.Add(s);
            a.Add(b);
            a.Add(nu);
            a.Add(t);
            t["string"] = s2;
            t["nill"] = nu2;
            t["cislo"] = n2;
            Console.WriteLine(a.ToStringPressed());
            JArray aa = new JArray();
            a.Add(aa);
            aa.Add(nu3);
            aa.Add(b2);
            Console.WriteLine(a.ToStringPressed());
        }
        [TestMethod()]
        public void JArrayToStringTest()
        {
            JArray a = new JArray();
            JNumber n = new JNumber(42);
            JNumber n2 = new JNumber(7.3);
            JString s = new JString("pokus");
            JString s2 = new JString("pokus2");
            JBool b = new JBool(true);
            JBool b2 = new JBool(false);
            JNull nu = new JNull();
            JNull nu2 = new JNull();
            JNull nu3 = new JNull();
            JToken t = new JToken();
            JRoot root = new JRoot();
            root["pole"] = a;
            a.Add(n);
            a.Add(s);
            a.Add(b);
            a.Add(nu);
            a.Add(t);
            t["string"] = s2;
            t["nill"] = nu2;
            t["cislo"] = n2;                        
            Console.WriteLine(a.ToString());
            JArray aa = new JArray();
            a.Add(aa);
            aa.Add(nu3);
            aa.Add(b2);
            Console.WriteLine(a.ToString());

        }
    }
}
