﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 7, 8, 4, 5, 15 };
            Array.Sort(myArray);
    
            foreach (var element in myArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
