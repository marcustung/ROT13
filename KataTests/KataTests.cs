using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests
{
	[TestClass()]
	public class KataTests
	{
		[TestMethod()]
		public void Rot13Test()
		{
			Assert.AreEqual("ROT13 example.", Kata.Rot13("EBG13 rknzcyr."));
			//Assert.Fail();
		}
	}
}