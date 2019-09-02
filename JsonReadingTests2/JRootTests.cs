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
	public class JRootTests
	{
		[TestMethod()]
		public void JRootTest()
		{
			JRoot root = new JRoot();
			Assert.IsNotNull(root);
			Assert.AreEqual("root", root.Name);

			JNumber n1 = new JNumber(15484885);
			JNumber n2 = new JNumber(15484885);
			root["n1"] = n1;
			root["n2"] = n2;
			root.Items.Add(n2.Name, n2);

			Console.WriteLine(root);


		}

		[TestMethod()]
		public void ToStringTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void ToStringPressedTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void ValueToStringTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void ValueToStringPressedTest()
		{
			Assert.Fail();
		}
	}
}