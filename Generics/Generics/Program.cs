using System.Security.Cryptography.X509Certificates;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H','E','L','L','O' };

            Program.toPrint(doubleArray);
            Program.toPrint(charArray);
        }

        public static void toPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("...............................");
        }
        
        public static void toPrint(char[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("...............................");
        }
    }
}
