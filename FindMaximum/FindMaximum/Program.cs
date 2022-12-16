using FindMaximumProblem;
using System;

namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Find max");
            Console.WriteLine("--------------------");
            GenericsMax<int> intMax = new GenericsMax<int>(25, 22, 21);
            int max = intMax.TestMaximum();
            Console.WriteLine("Max Value is: {0}", max);
            Console.WriteLine("--------------------");
            GenericsMax<double> doubleMax = new GenericsMax<double>(45.5, 36.1, 89.4);
            double dMax = doubleMax.TestMaximum();
            Console.WriteLine("Max Value is: {0}", dMax);
            Console.WriteLine("--------------------");
            GenericsMax<string> strMax = new GenericsMax<string>("111", "222", "333");
            string sMax = strMax.TestMaximum();
            Console.WriteLine("Max Value is: {0}", sMax);
            Console.WriteLine("--------------------");
            GenericsMax<string> strMax1 = new GenericsMax<string>("apple", "ball", "cat");
            sMax = strMax1.TestMaximum();
            Console.WriteLine("Max Value is: {0}", sMax);
        }


    }
}

