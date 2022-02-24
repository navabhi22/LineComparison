using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class CheckIfLinesAreEqual
    {
        /// <summary>
        /// Equalities the of line.
        /// </summary>
        /// <returns></returns>
        public static double Line1;
        public static double Line2;
        public bool EqualityOfLine()
        {
            CreatingLine line = new CreatingLine();
            Line1 = line.CreateLine();
            Line2 = line.CreateLine();
            if (Line1 == Line2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
