using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonReading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JsonReading.Tests
{
	[TestClass()]
	public class JsonExceptionTests
	{
		[TestMethod()]
		public void JsonExceptionTest()
		{
			try
			{
				var v = JReader.Parse(File.ReadAllText("FilePath"));
			}
			catch
			{

			}
		}

		[TestMethod()]
		public void JsonCorrectExceptionTest()
		{
			try
			{
				var v = JReader.Parse(File.ReadAllText("FilePath"));
			}
			catch (IOException ex)
			{
				//Chyba v načítání souboru
			}
			catch (JsonException ex)
			{
				//Chyba ve formátu souboru
			}
		}
	}
}