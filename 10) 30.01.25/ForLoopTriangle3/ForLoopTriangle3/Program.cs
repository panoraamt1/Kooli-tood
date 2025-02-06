namespace ForLoopTriangle3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kolmnurga suurus.");
            int i, j, k = 1, rows;
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    
                    Console.Write("{0} ", k++);
                }
                Console.WriteLine();
            }
        }
    }
}
