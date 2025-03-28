namespace RandomAsterisk
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Random rnd = new Random();
            int ast = rnd.Next(1,21);
            
            
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < ast; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
