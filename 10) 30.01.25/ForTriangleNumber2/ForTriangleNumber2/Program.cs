namespace ForTriangleNumber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int i, j, rows;

            Console.WriteLine("Sisesta kolmnurga suurus.");
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", i);
                }
                Console.Write("\n");
            }
        }
    }
}
