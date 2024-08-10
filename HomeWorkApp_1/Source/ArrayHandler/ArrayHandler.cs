using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.Threading.Channels;

namespace HomeWorkApp.Source
{
    public class ArrayHandler
    {
        public int Max(int[] array,out int index, out int absIndex, int start = 0, int end = 0)
        {
            index = -1;

            absIndex = -1;

            if (array == null) return -1;

            if (array.Length == 0) return -1;

            var max = array[start];

            start = start < 0 || start > array.Length ? 0 : start;

            end = end > array.Length || end < 0 ? array.Length - 1 : end;

            for(int i = start; i < end; i++)
            {
                if (max <= array[i]) 
                {
                    max = array[i];
                    index = i;
                    absIndex = i + start;
                } 
            }

            return max;
        }

        public int[] RotateInverse(int[] array, int k) 
            => Inverse(Rotate(array, k));

        public int[] Rotate(int[] array, int k)
        {
            if (array == null || array.Length == 0) return new int[] { };

            var j = 0;

            while(j < k)
            {
                var last = array[array.Length - 1];

                for (int i = array.Length - 1; i > 0; i--)
                    array[i] = array[i - 1];

                array[0] = last;

                j++;
            }

            foreach(var a in array)
             Debug.WriteLine(a);

            return array;
        }

        public int[] Inverse(int[] array)
        {
            for(int i = 0; i < array.Length / 2; i++)
            {
                var right = array[array.Length - i - 1];

                array[array.Length - i - 1] = array[i];

                array[i] = right;
            }

            return array;
        }

        public List<int> SortByEven(List<int> array)
        {
            var clone = array.ToList();

            var even = new List<int>();

            for (int i = 0; i < clone.Count; i++)
                if (clone[i] % 2 == 0) even.Add(clone[i]);

            for(int i = 0; i < even.Count; i++)
            {
                var imax = i;

                for(int j = i + 1; j < even.Count; j++)
                    if (even[imax] < even[j]) imax = j;

                var temp = even[i];

                even[i] = even[imax];

                even[imax] = temp;
            }

            var k = 0;

            for (int i = 0; i < clone.Count; i++)
            {
                if (clone[i] % 2 == 0)
                {
                    clone[i] = even[k];
                    k++;
                } 
            }

            return clone;
        }

        public int[] Add(int[] value)
        {
            if (value == null || value.Length == 0) return new int[1] { 1 };

            value[value.Length - 1]++;


            for (int i = value.Length - 1; i >= 0; i--)
            {
                if (value[i] != 10) continue;

                value[i] = 0;

                if (i - 1 == -1) 
                {
                    var clone = new int[value.Length + 1];

                    Array.Copy(value, 0, clone, 1, value.Length);

                    clone[0] = 1;

                    return clone;
                }

                value[i - 1] += 1;
            }

            for (int i = 0; i < value.Length; i++)
                Debug.WriteLine($"Result: {value[i]}");

            return value;
        }
    }
}
