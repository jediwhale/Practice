using NUnit.Framework;
using GameOfLife;

namespace GameOfLifeTest {
	[TestFixture]
	public class SampleTest {
		[Test]
		public void TestMethod() {
			var sample = new Sample();
			Assert.AreEqual(42, sample.Answer());
		}
	}
}
