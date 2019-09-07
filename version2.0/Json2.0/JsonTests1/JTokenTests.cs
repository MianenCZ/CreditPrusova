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
            JArray a = new JArray();
            JNumber n = new JNumber(7.3);
            JString s = new JString("example");
            JBool b = new JBool(true);
            JNull nu = new JNull();
            JArray aa = new JArray();
            JToken root = new JToken();
            JToken t = new JToken();
            JToken tt = new JToken();
            JRoot r = new JRoot();
            aa.Value.Add(n);
            aa.Value.Add(b);
            tt["cislo"] = n;
            tt["nil"] = (nu);
            aa.Value.Add(tt);
            a.Value.Add(s);
            a.Value.Add(aa);
            a.Value.Add(n);
            t["inside"]=aa;
            t["string"]=s;
            root["dalsi cislo"]=n;
            root["token"]=t;
            r["mnau"] = root;
            Console.WriteLine(root.ToStringPressed());
            Console.WriteLine(root.ToString());
            Console.WriteLine(r.ToStringPressed());
            Console.WriteLine(r.ToString());
        }
    }
}
