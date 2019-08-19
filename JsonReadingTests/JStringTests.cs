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
		public void JStringTest()
		{
			JString s = new JString("test");
			Assert.IsNotNull(s);
			Assert.AreEqual("test", s.Name);
		}

		[TestMethod()]
		public void JStringFillTest()
		{
			JString s = new JString("test")
			{ Value = "Value"};
			Assert.IsNotNull(s);
			Assert.AreEqual("test", s.Name);
			Assert.AreEqual("Value", s.Value);
		}

		[TestMethod()]
		public void JStringToStringTest()
		{
			JString s = new JString("test")
			{ Value = "Value" };
			Assert.IsNotNull(s);
			Assert.AreEqual("test", s.Name);
			Assert.AreEqual("Value", s.Value);
			Console.WriteLine(s.ToString());
			Assert.AreEqual("\"test\": \"Value\"", s.ToString());
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
	}
}