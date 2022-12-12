using System.Security.Cryptography.X509Certificates;

namespace Generics
{
    class Program
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(".............................");
        }
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 ,5.5};
            char[] charArray = { 'H','E','L','L','O' };

            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<char>(charArray);
        }

        

       
    }
}
