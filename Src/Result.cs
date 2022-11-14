using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'formingMagicSquare' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY s as parameter.
         */

        public static int formingMagicSquare(List<List<int>> s)
        {
            List<int> data = new List<int>();

            foreach (var i in s)
            {
                foreach (var j in i)
                {
                    data.Add(j);
                }
            }

            List<List<int>> magic = new List<List<int>> {
                new List<int> {8, 1, 6, 3, 5, 7, 4, 9, 2},
                new List<int> {6, 1, 8, 7, 5, 3, 2, 9, 4},
                new List<int> {4, 9, 2, 3, 5, 7, 8, 1, 6},
                new List<int> {2, 9, 4, 7, 5, 3, 6, 1, 8},
                new List<int> {8, 3, 4, 1, 5, 9, 6, 7, 2},
                new List<int> {4, 3, 8, 9, 5, 1, 2, 7, 6},
                new List<int> {2, 7, 6, 9, 5, 1, 4, 3, 8},
                new List<int> {6, 7, 2, 1, 5, 9, 8, 3, 4}};

            List<int> sums = new List<int>();
            int sum = 0;

            for (int i = 0; i < magic.Count; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    sum = data[j] != magic[i][j] ? sum += Math.Abs(data[j] - magic[i][j]) : sum;
                }

                sums.Add(sum);
                sum = 0;
            }

            return sums.Min();
        }
    }
}