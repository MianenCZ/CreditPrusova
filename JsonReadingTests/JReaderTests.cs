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
	public class JReaderTests
	{
		[TestMethod()]
		public void JReaderCreateTest()
		{
			JReader r = new JReader();
			Assert.IsNotNull(r);
		}


		[TestMethod()]
		public void JReaderExample()
		{
			JReader r = new JReader();
			var val = r["TestParams/Sets"];
		}
	}
}