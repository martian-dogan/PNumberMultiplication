using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbersMultiplication.Services.Interface
{
    public interface ILog
    {
        public void Write(List<int> headers, int[,] multiplicationList);
    }
}
