using System.Drawing;

namespace SwitchLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta vokaal.");
            string vok = Console.ReadLine();


            switch (vok.ToLower())
            {
                case "a":
                    Console.WriteLine("Sisestasid: " + vok);
                    break;
                case "e":
                    Console.WriteLine("Sisestasid: " + vok);
                    break;
                case "i":
                    Console.WriteLine("Sisestasid: " + vok);
                    break;
                case "o":
                    Console.WriteLine("Sisestasid: " + vok);
                    break;
                case "u":
                    Console.WriteLine("Sisestasid: " + vok);
                    break;
                case "õ":
                    Console.WriteLine("Sisestasid: " + vok);
                    break;
                case "ä":
                    Console.WriteLine("Sisestasid: " + vok);
                    break;
                case "ö":
                    Console.WriteLine("Sisestasid: " + vok);
                    break;
                case "ü":
                    Console.WriteLine("Sisestasid: " + vok);
                    break;
                default:
                    Console.WriteLine("See pole vokaal.");
                    break;
            }
        }
    }
}
