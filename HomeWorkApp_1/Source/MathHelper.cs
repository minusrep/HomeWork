using System.Diagnostics;
using System.Numerics;

namespace HomeWorkApp.Source
{
    public class MathHelper
    {
        public BigInteger Factorial(int n)
        {
            if (n < 0 || n > 20) return -1;

            if (n == 0)
                return 1;

            return Factorial(n - 1) * n;

            // O(1) | O(n) | O(n)
        }

        public int[] Fibonacci(int n)
        {
            if (n > 32) return new int[] { -1 };

            var array = new List<int> { };

            for(int i = 0; i < n; i++)
            {
                var value = i < 2 ? 1 : array[i - 1] + array[i - 2];

                array.Add(value);
            }

            return array.ToArray();
        }

        public int BinaryCountOnes(int n)
        {
            if (n < 0) return -1;

            var count = 0;

            while(n != 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
    }
}
