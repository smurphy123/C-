using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "First line", "second line", "Third line" };
            File.WriteAllLines("FormattedFile.txt", formatLines(lines));

            string[] otherLines = { "Another first line", "Another second line", "Another third line" };
            File.WriteAllLines("AnotherFormattedFile.txt", formatLines(otherLines));
        }

        static string[] formatLines(string[] unformattedLines)
        {
            string[] formattedLines = new string[unformattedLines.Length];

            for(int i = 0; i < formattedLines.Length; i++)
            {
                formattedLines[i] = String.Format("{0} {1} {2}", "***", unformattedLines[i], "***");
            }

            return formattedLines;
        }
    }
}
