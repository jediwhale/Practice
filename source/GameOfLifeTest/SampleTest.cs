using NUnit.Framework;
using GameOfLife;

namespace GameOfLifeTest {
	[TestFixture]
	public class SampleTest {
		[Test]
		public void AnswerIs42() {
			var sample = new Sample();
			Assert.AreEqual(42, sample.Answer());
		}
	}
}
