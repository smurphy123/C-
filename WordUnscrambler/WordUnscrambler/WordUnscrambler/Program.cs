using System;
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
            int a = 10;
            ChangeNumber(ref a);
            Console.WriteLine(a);
        }

        static void ChangeNumber(ref int a)
        {
            a = 90;
        }
    }
}
