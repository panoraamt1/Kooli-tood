namespace InsertNrForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta tärnide arv.");

            int arv = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arv; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
