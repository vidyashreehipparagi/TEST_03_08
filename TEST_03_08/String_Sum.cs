using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_03_08
{
    internal class String_Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s=Console.ReadLine();
            char[]ch= s.ToCharArray();
            int sum = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= '1' && ch[i] <= '9')
                {
                    int a = (int)char.GetNumericValue(ch[i]);
                    sum = sum + a;
                }

             }
            Console.WriteLine(sum);
        }
    }
}
