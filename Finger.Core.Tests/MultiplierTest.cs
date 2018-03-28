using NUnit.Framework;

namespace Finger.Core.Tests
{
    [TestFixture]
    public class MultiplierTest
    {
        [Test]
        public void Multiplier_Multiply_RightResult()
        {
            var x = 4;
            var y = 6;
            var expectedResult = 24;
            var multiplier = new Multiplier();

            var multiplicationКesult = multiplier.Muktiply(x, y);

            Assert.AreEqual(multiplicationКesult, expectedResult);
        }

        [Test]
        public void Multiplier_Multiply_RightResult2()
        {
            var x = 4;
            var y = 0;
            var expectedResult = 0;
            var multiplier = new Multiplier();

            var multiplicationКesult = multiplier.Muktiply(x, y);

            Assert.AreEqual(multiplicationКesult, expectedResult);
        }

        [Test]
        public void Multiplier_Multiply_RightResult3()
        {
            var x = -4;
            var y = 5;
            var expectedResult = -20;
            var multiplier = new Multiplier();

            var multiplicationКesult = multiplier.Muktiply(x, y);

            Assert.AreNotEqual(multiplicationКesult, expectedResult);
        }
    }
}
