using Microsoft.VisualStudio.TestTools.UnitTesting;
using test1;

namespace TestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var m = new Manager();
			var m2 = m.Add(1, 4);
			Assert.IsTrue(m2 == 3);
		}
	}
}