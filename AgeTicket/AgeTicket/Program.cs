namespace AgeTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui vana olete?");
            int age = int.Parse(Console.ReadLine());
            if (age <= 0)
            {
                Console.WriteLine("ERROR");
            }
            else if (age >= 1 && age <= 6)
            {
                Console.WriteLine("Pilet on tasuta.");
            }
            else if (age >= 7 && age <= 18)
            {
                Console.WriteLine("Õpilaspilet.");
            }
            else
            {
                Console.WriteLine("Täistasuline pilet.");
            }

        }
    }
}
