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
        public void JArrayToStringPressedTest()
        {
            JArray a = new JArray();
            JNumber n = new JNumber(42);
            JString s = new JString("pokus");
            JBool b = new JBool(true);
            JNull nu = new JNull();
            JToken t = new JToken();
            a.Value.Add(n);
            a.Value.Add(s);
            a.Value.Add(b);
            a.Value.Add(nu);
            t["string"] = s;
            t["nill"] = nu;
            t["cislo"] = n;
            a.Value.Add(t);
            JArray aa = new JArray();
            aa.Value.Add(nu);
            aa.Value.Add(b);
            a.Value.Add(aa);
            Console.WriteLine(a.ToStringPressed());
            Assert.IsNotNull(a);
            //.AreEqual("[42,\"pokus\",true,null,[null,true]]", a.ToStringPressed());
        }
        [TestMethod()]
        public void JArrayToStringTest()
        {
            JArray a = new JArray();
            JNumber n = new JNumber(42);
            JString s = new JString("pokus");
            JBool b = new JBool(true);
            JNull nu = new JNull();
            JToken t = new JToken();
            a.Value.Add(n);
            a.Value.Add(s);
            a.Value.Add(b);
            a.Value.Add(nu);
            t["string"] = s;
            t["nill"] = nu;
            t["cislo"] = n;            
            a.Value.Add(t);
            Console.WriteLine(a.ToString());
            JArray aa = new JArray();
            aa.Value.Add(nu);
            aa.Value.Add(b);
            a.Value.Add(aa);
            t["array"] = aa;
            Console.WriteLine(a.ToString());
            JArray aaa = new JArray();
            aaa.Value.Add(s);
            aaa.Value.Add(nu);
            aa.Value.Add(aaa);
            Console.WriteLine(a.ToString());

        }
    }
}
