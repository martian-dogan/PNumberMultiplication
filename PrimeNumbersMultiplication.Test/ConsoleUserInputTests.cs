using NUnit.Framework;
using PrimeNumbersMultiplication.Services;
using PrimeNumbersMultiplication.Services.Interface;
using System.Collections.Generic;

namespace PrimeNumbersMultiplication.Test
{
    public class ConsoleUserInputTests
    {
        IUserInput consoleUserInput;


        [SetUp]
        public void SetUp()
        {
            consoleUserInput = new ConsoleUserInput();

        }

        [Test]
        public void GetPrimeNumbers_Successfull_When_ReadValidUserInput()
        {
            var userInput = 3;
            var result = consoleUserInput.GetPrimeNumbers(userInput);
            Assert.AreEqual(userInput, result.Count);
        }


        [Test]
        public void GetPrimeNumbers_Fail_When_ReadInvalidUserInput()
        {
            var userInput = -4;
            var result = consoleUserInput.GetPrimeNumbers(userInput);
            Assert.AreNotEqual(userInput, result.Count);
        }


        [Test]
        public void GetPrimeNumbersMultiplications_Successfull_When_ListIsNotEmpty()
        {
            List<int> primeNumbers = new List<int>{ 2, 3, 5 };
            var index = 1;
            var result = consoleUserInput.GetPrimeNumbersMultiplications(primeNumbers);
            Assert.AreEqual(primeNumbers[index] * primeNumbers[index], result[index, index]);
        }

        [Test]
        public void GetPrimeNumbersMultiplications_ReturnNull_When_ListIsEmpty()
        {
            List<int> primeNumbers = new List<int>();
            var result = consoleUserInput.GetPrimeNumbersMultiplications(primeNumbers);
            Assert.AreEqual(null, result);
        }


    }
}
