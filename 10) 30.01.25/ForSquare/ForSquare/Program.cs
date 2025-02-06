namespace ForSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kas soovid ruutu teha?");
            Console.WriteLine("Y/N");
            string yesNo = Console.ReadLine().ToLower();

            if(yesNo == "y")
            {
                Square();
            }

        }

        static void Square()
        {
            Console.WriteLine("Sisesta suurus.");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();

            for (int i = 0; i < a - 2; i++)
            {
                Console.Write("* ");

                for (int j = 0; j < a - 2; j++)
                {
                    Console.Write("  ");
                }

                Console.WriteLine("*");
            }

            for (int i = 0; i < a; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}
