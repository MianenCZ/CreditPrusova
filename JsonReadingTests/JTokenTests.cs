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
	public class JTokenTests
	{
		[TestMethod()]
		public void ToStringPressedTest()
		{
			JToken t = new JToken("test");
		}
	}
}