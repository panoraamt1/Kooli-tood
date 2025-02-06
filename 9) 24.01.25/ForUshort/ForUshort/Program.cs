namespace ForUshort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int length = ushort.MaxValue;

            for (; ;)
            {

                for (int i = 0; i <= length; i++)
                {
                    Console.WriteLine("i väärtus on: {0}", i);
                }

            }
        }
    }
}
