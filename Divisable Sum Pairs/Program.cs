using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Solved in 12 min
/// </summary>

namespace Divisable_Sum_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = divisableSumPairs(n,k, ar);
            Console.WriteLine(result);
        }

        static int divisableSumPairs(int n, int k, int[] ar)
        {
            int ans = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar.Length; j++)
                {
                    if( i != j)
                    {
                        if (IsDivisable(ar[i] + ar[j], k))
                            ans++;
                    }
                }
            }

            return ans/2;
        }

        static bool IsDivisable(int a, int b)
        {
            if (a % b == 0)
                return true;
            return false;
        }

    }
}
