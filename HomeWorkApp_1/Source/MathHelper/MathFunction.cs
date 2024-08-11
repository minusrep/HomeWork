using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkApp.Source
{
    public class MathFunction
    {
        public void BubbleSort(int[] array, Func<int, int, bool> orderBy)
        {
            var n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (orderBy(array[j], array[j + 1]))
                    {
                        var temp = array[j];

                        array[j] = array[j + 1];

                        array[j + 1] = temp;
                    }
                }
            }
        }

        public int[] SelectionSort(int[] array, out int comparisonCount, out int swapCount)
        {
            var n = array.Length;

            comparisonCount = 0;

            swapCount = 0;

            for (var i = 0; i < n - 1; i++)
            {
                var minIndex = i;

                for (var j = i + 1; j < n; j++)
                {
                    comparisonCount++;

                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    var temp = array[i];

                    array[i] = array[minIndex];

                    array[minIndex] = temp;

                    swapCount++;
                }
            }

            return array;
        }

        public int RecursiveSum(int[] array)
        {
            if (array.Length == 0) return 0;

            return array[0] + RecursiveSum(array[1..]);
        }

        public int RecursiveEvenSum(int[] array)
        {
            if (array.Length == 0) return 0;

            var sum = array[0] % 2 == 0 ? array[0] : 0;
            
            return sum +  RecursiveEvenSum(array[1..]);
        }

        public int RecursiveMax(int[] array)
        {
            if (array.Length == 1) return array[0];

            var max = array[0];

            var next = RecursiveMax(array[1..]);

            return max > next ? max : next;
        }

        public string Reverse(string value)
        {
            if(value.Length == 0) return string.Empty;

            return value[value.Length - 1] + Reverse(value[..(value.Length - 1)]);
        }

        public bool IsPallidrome(string value)
        {
            if (value.Length == 1 || value.Length == 0) return true;

            return value[0] == value[value.Length - 1] && IsPallidrome(value[1..(value.Length - 1)]);
        }

        public int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public int DigitsSum(int n)
        {
            if (n == 0) return 0;

            return n % 10 + DigitsSum(n / 10);
        }
    }
}
