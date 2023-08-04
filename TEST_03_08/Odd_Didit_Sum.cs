using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_03_08
{
    internal class Odd_Didit_Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int digit;
            int sum = 0;
            while(num>0)
            {
                digit=num%10;
                if (digit % 2 != 0)
                {
                    sum=sum+digit;
                }
                num=num/10;
            }
            Console.WriteLine(sum);
        }
    }
}
