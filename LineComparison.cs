using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineComparison
    {
        /// <summary>
        /// Comparison of lines
        /// </summary>
        public static double Line1;
        public static double Line2;
        public void ToCompareLines()
        {
            CreatingLine line = new CreatingLine();
            Line1 = line.CreateLine();
            Line2 = line.CreateLine();

            if (Line1 > Line2)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else if (Line1 < Line2)
            {
                Console.WriteLine("Line2 is greater than Line1 ");
            }
            else
            {
                Console.WriteLine("Lines are equal");
            }
        }
    }
}
