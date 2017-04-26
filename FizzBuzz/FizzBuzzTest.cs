using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void ShouldReturnFizz()
        {
            Assert.AreEqual(Program.CalculateFizzBuzz(3), "Fizz");
        }
    }
}
