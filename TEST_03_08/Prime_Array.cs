using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace TEST_03_08
{
    internal class Prime_Array
    {
      

            public static bool IsPrime(int n)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                        break;
                    }
                }
                return true;

            }
            static void Main(string[] args)
            {
                int[] a = { 1, 6, 12, 9, 5, 31 };

                for (int i = 0; i < a.Length; i++)
                {
                    int num = a[i];
                    if (Prime_Array.IsPrime(num))
                    {
                        Console.WriteLine(a[i]);
                    }
                }


            }
        }
}
