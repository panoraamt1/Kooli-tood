namespace FoorLoopKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("kill-koll ");
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("kill-koll ");

                    // Inner loop
                    for (int k = 0; k < 1; k++)
                    {
                        Console.WriteLine("killadi-koll ");
                    }
                }
            
            }

            for (int l = 0; l < 4; l++)
            {
                Console.WriteLine("kill-koll ");
            }
        }
    }
}
