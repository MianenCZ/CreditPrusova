using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonReading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonReadingTests.MianenTests
{
	[TestClass()]
	public class BasicTests
	{
		[TestMethod()]
		public void JToken()
		{
			//TODO: cannot create root without sending a name
			//JToken.IsRoot flag
			JToken t = new JToken("");
			Assert.IsNotNull(t.Value);
			Assert.AreEqual(0, t.Value.Count);
			//Missing basic ToStringMethod
			t.ToString();
			Console.WriteLine(t.ToString());
			Assert.AreEqual("{}", t.ToStringPressed());

		}

		[TestMethod()]
		public void JTokenAdding()
		{

			JToken t = new JToken("");
			JString s = new JString(Name: "line1", Value: "150 foxtrot");

			t.Value.Add(s);
			//Newtonsoft.Json.Linq.JObject a = Newtonsoft.Json.Linq.JObject.Parse(t.ToString(0));
			//TODO: Hwo to add an Item. It is internal, there is no way, how to do that outside the library
			//TODO: To many methods ToString and noone to write a root object

			Assert.IsNotNull(t.Value);
			Assert.AreEqual(1, t.Value.Count);
		}

		[TestMethod()]
		public void JTokenRecursive()
		{
			//TODO: Recursive adding to item
			JToken t = new JToken("root");
			t.Value.Add(t);

			Console.WriteLine(t.ToString(0));

			Assert.AreEqual(1, t.Value.Count);
		}


	}
}
