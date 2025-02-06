namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] myArray = { "H", "e", "l", "l", "o" };
            int len = myArray.Length;        
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
