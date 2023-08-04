using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TEST_03_08
{
    internal class Avg
    {
        static void Main(string[] args)
        { 
            //avg of digit
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            double avg = 0;
            while (num > 0)
            {
              int digit=num % 10;
                sum = sum + digit;
                num = num / 10;
                count++;
            }
            avg= sum / count;
            Console.WriteLine(avg);

        }
    }
}
