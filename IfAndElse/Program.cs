namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");

            int num = Convert.ToInt32 (Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("No can do mate.");
            }

            else
            {
                Console.WriteLine("Be ye " + num * 3 + ", I see, I see.");
            }
        }
    }
}
