using PrimeNumbersMultiplication.Services;
using PrimeNumbersMultiplication.Services.Interface;
using System;

namespace PrimeNumbersMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInput userInput = new ConsoleUserInput();
            var primeNumberCount = userInput.Read();
            var primeNumbers = userInput.GetPrimeNumbers(primeNumberCount);
            var primeNumbersAndMultiplications = userInput.GetPrimeNumbersMultiplications(primeNumbers);

            ILog log = new ConsoleLog();
            log.Write(primeNumbers, primeNumbersAndMultiplications);
        }
    }
}
