using NUnit.Framework;
using PrimeNumbersMultiplication.Constants;
using PrimeNumbersMultiplication.Services;
using PrimeNumbersMultiplication.Services.Interface;
using System;
using System.Collections.Generic;
using System.IO;

namespace PrimeNumbersMultiplication.Test
{
    public class ConsoleLogTest
    {

        ILog consoleLog;

        List<int> listHeaders;
        int[,] primeNumbers;

        [SetUp]
        public void SetUp()
        {
            consoleLog = new ConsoleLog();
            listHeaders = new List<int> { 2, 3, 5 };
            primeNumbers = new int[listHeaders.Count, listHeaders.Count];
            primeNumbers[0, 0] = 4;
            primeNumbers[0, 1] = 6;
            primeNumbers[0, 2] = 10;
            primeNumbers[1, 0] = 6;
            primeNumbers[1, 1] = 9;
            primeNumbers[1, 2] = 15;
            primeNumbers[2, 0] = 10;
            primeNumbers[2, 1] = 15;
            primeNumbers[2, 2] = 25;

        }

        [Test]
        public void Write_When_ListIsNotEmpty()
        {
            
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            consoleLog.Write(listHeaders, primeNumbers);
            var getCurrentOutput = consoleOutput.ToString();
            var length = getCurrentOutput.Replace(UIConst.EmptyBlock, "").Length;
            Assert.Greater(length, 0);

        }


        [Test]
        public void Write_When_ListIsEmpty()
        {

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            consoleLog.Write(new List<int>(), null);
            var getCurrentOutput = consoleOutput.ToString();
            var length = getCurrentOutput.Replace(UIConst.EmptyBlock, "").Length;
            Assert.AreEqual(length, 0);

        }

        [Test]
        public void Write_When_ArrayIsEmpty()
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            consoleLog.Write(listHeaders, new int[0,0]);
            var getCurrentOutput = consoleOutput.ToString();
            var length = getCurrentOutput.Replace(UIConst.EmptyBlock, "").Length;
            Assert.AreEqual(length, listHeaders.Count+2);

        }
    }
}
