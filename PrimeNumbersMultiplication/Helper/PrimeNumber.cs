using PrimeNumbersMultiplication.Constants;

namespace PrimeNumbersMultiplication.Helper
{
    public class PrimeNumber
    {
        public static bool Check(int number)
        {
            bool result = true;
            for (int i = UIConst.MinPrimeNumber; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }

            if (number < 2) result = false;
            return result;

        }
    }
}
