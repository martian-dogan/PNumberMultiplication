using PrimeNumbersMultiplication.Constants;
using PrimeNumbersMultiplication.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbersMultiplication.Services
{
    public class ConsoleLog : ILog
    {
        public void Write(List<int> headers, int[,] multiplicationList)
        {
            Console.Write(UIConst.EmptyBlock);
            if (headers.Any())
            {
                foreach (var item in headers)
                {
                    Console.Write(item + UIConst.EmptyBlock);
                }

                Console.WriteLine();

                if (multiplicationList.Length > 0)
                {
                    for (int i = 0; i < headers.Count; i++)
                    {
                        Console.Write(headers[i] + UIConst.EmptyBlock);
                        for (int j = 0; j < headers.Count; j++)
                        {
                            Console.Write(multiplicationList[i, j] + UIConst.EmptyBlock);
                        }
                        Console.WriteLine();
                    }
                }
                
            }
            
        }
    }
}
