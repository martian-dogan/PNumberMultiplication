using System.Collections.Generic;

namespace PrimeNumbersMultiplication.Services.Interface
{
    public interface IUserInput
    {
        public int Read();
        public List<int> GetPrimeNumbers(int limit);
        public int[,] GetPrimeNumbersMultiplications(List<int> primeNumbers);
    }
}
