using NUnit.Framework;
using PrimeNumbersMultiplication.Helper;

namespace PrimeNumbersMultiplication.Test
{

    public class PrimeNumberTest
    {
        [Test]
        public void Check_ReturnTrue_When_InputIsPrimeNumber()
        {
            var result = PrimeNumber.Check(5);
            Assert.IsTrue(result);
        }

        [Test]
        public void Check_ReturnFalse_When_InputIsLess2()
        {
            var result = PrimeNumber.Check(1);
            Assert.IsFalse(result);
        }


        [Test]
        public void Check_ReturnFalse_When_InputIsNotPrimeNumber()
        {
            var result = PrimeNumber.Check(1);
            Assert.IsFalse(result);
        }
    }
}
