﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_03_08
{
    internal class ArrayReverse
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int j = arr.Length - 1;
            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length / 2; i++)
            {
               
              int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }
           // Console.WriteLine();
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
