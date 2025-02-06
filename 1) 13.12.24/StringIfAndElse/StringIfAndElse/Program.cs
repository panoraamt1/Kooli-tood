namespace StringIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisetage nimi.");

            string name = Console.ReadLine();
            
            if (name != "")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Tere " + name);
                Console.ResetColor();
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("On vaja sisestada nimi.");
                Console.ResetColor();
            }
        }
    }
}
