using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Problems
{
    internal class Arrays_DS
    {
        public static void reverseArray(List<int> a)
        {
            var newList = new List<int>();
            for (int i = a.Count() - 1; i >= 0; i--)
            {
                newList.Add(a[i]);
            }
            foreach (int i in newList)
                Console.WriteLine(i);
        }

        public static int hourglassSum(List<List<int>> arr)
        {
            var array = arr.Select(x => x.ToArray()).ToArray();
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < array.Length - 2; i++) {
                for (int j = 0; j < array.Length - 2; j++)
                {
                    sum = array[i][j] + array[i][j+1] + array[i][j + 2]
                        + array[i + 1][j + 1]
                        + array[i + 2][j] + array[i + 2][j + 1] + array[i + 2][j + 2];

                    max = Math.Max(max, sum);
                }
            }

            return max;
        }
    }
}
