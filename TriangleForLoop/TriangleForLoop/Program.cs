namespace TriangleForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk tärnidest, ehk poolik püramiid");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("Sisestage ridade arv.");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write('\n');

            
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
