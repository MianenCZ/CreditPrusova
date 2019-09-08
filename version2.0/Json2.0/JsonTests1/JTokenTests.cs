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
    public class JTokenTests
    {
        [TestMethod()]
        public void JTokenToStringPressedTest()
        {

            JNumber n = new JNumber(7.3);
            JNumber n2 = new JNumber(42);
            JNumber n3 = new JNumber(3.14);
            JString s = new JString("example");
            JBool b = new JBool(true);
            JNull nu = new JNull();
            JArray aa = new JArray();
            JToken root = new JToken();
            JToken t = new JToken();
            JToken tt = new JToken();
            JRoot r = new JRoot();
            r["mnau"] = root;
            root["dalsi cislo"] = n;
            root["token"] = t;
            t["inside"] = aa;
            t["string"] = s;
            aa.Add(n2);
            aa.Add(b);
            aa.Add(tt);
            tt["cislo"] = n3;
            tt["nil"] = (nu);

            try { aa.Add(nu); }
            catch (JsonDuplicatedException e) { Console.WriteLine("zkusili jsme pridat podruhe"); }

            Console.WriteLine(root.ToStringPressed());
            Console.WriteLine(root.ToString());
            Console.WriteLine(r.ToStringPressed());
            Console.WriteLine(r.ToString());
        }
    }
}
