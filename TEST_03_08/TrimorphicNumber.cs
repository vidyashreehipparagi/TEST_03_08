using System;
using System.Collections.Generic;

using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_03_08
{
    internal class TrimorphicNumber
    {
        static void Main(string[] args)
        {
            //trimorphic number
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int cube = num * num * num;
            int a= cube % 10;
            

            
            if(temp == a)
            {
                Console.WriteLine("trimorphic number");
            }
            else
            {
                Console.WriteLine("not trimorphic number");
            }

        }
    }
}
