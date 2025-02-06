namespace ForLoopShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage püramiidi suurus.");
            int i, j, n;
            Console.WriteLine("-----------------------------------------------------");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------");

            Console.Write('\n');


            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}",j);
                }
                for (j = i-1; j >= 1; j--)
                {
                    Console.Write("{0}",j);
                }

                Console.Write("\n");
            }
        }
    }
}
