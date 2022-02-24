using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class CreatingLine
    {
        /// <summary>
        /// Creates the line.
        /// </summary>
        public static int x1;
        public static int x2;
        public static int y1;
        public static int y2;
            public void CreateLine()
            {
                Random random = new Random();
                x1 = random.Next(10);
                y1 = random.Next(10);

                x2 = random.Next(10);
                y2 = random.Next(10);

                double LineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));
                Console.WriteLine("The length of line is  " + LineLength);


            }
    }
}
