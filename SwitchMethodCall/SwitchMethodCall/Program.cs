using Microsoft.VisualBasic;

namespace SwitchMethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1, 2 or 3.");

            

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Coupe();
                break;
                case 2:
                    Truck();
                break;
                case 3:
                    Buss();
                break;
                default:
                    Console.WriteLine("It's 1-3. not " + choice);
                break;
            }
        }

        static void Coupe()
        {
            Console.WriteLine("It's a coupee.");
        }

        static void Truck()
        {
            Console.WriteLine("It's a truck.");
        }

        static void Buss()
        {
            Console.WriteLine("It's a buss.");
        }
    }
}
