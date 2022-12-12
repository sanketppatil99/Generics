namespace Generics
{
    public class PrintArray<T>
    {
        private T[] inputArray;

        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public void toPrint()
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(".........................");
        }
    }
}
