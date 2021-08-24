using PrimeNumbersMultiplication.Constants;
using PrimeNumbersMultiplication.Helper;
using PrimeNumbersMultiplication.Services.Interface;
using System;
using System.Collections.Generic;

namespace PrimeNumbersMultiplication.Services
{
    public class ConsoleUserInput : IUserInput
    {
        
        public List<int> GetPrimeNumbers(int primeNumberCount)
        {
            List<int> result= new List<int>();
            
            var currentPrimeNumber = UIConst.MinPrimeNumber;

            while (result.Count < primeNumberCount)
            {
                if (PrimeNumber.Check(currentPrimeNumber))
                {
                    result.Add(currentPrimeNumber);
                }
                
                currentPrimeNumber++;
           
            }

            return result;
              
        }

        public int[,] GetPrimeNumbersMultiplications(List<int> primeNumbers)
        {
            if (primeNumbers.Count == 0) return null;
            var length = primeNumbers.Count;
            int[,] result = new int[length, length];
            
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    result[i, j] = primeNumbers[i] * primeNumbers[j];
                }
            }
            return result;
        }

        public int Read()
        {
            int primeNumberCount = 0;
            do
            {
                Console.WriteLine(UIConst.PleaseEnterPrimeNumber);
            } while (!int.TryParse(Console.ReadLine(), out primeNumberCount) || primeNumberCount < UIConst.MinPrimeNumber);

            return primeNumberCount;
        }
    }
}
