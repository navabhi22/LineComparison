using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            CheckIfLinesAreEqual result = new CheckIfLinesAreEqual();
            bool x = result.EqualityOfLine();
            
            if ( x == true)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }

        }
    }
}