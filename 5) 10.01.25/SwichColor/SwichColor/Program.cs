using System.Drawing;

namespace SwichColor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Colour c = (Colour)(new Random()).Next(0, 5);

            switch (c)
            {
                case Colour.Blue:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("The color is blue.");
                    break;
                case Colour.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("The color is green.");
                    break;
                case Colour.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("The color is red.");
                    break;
                case Colour.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("The color is yellow.");
                    break;
                case Colour.Purple:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Clear();
                    Console.WriteLine("The color is purple.");
                    break;
                case Colour.Brown:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    Console.WriteLine("The color is brown.");
                    break;
                default:
                    break;
            }

            for (int i = 0; i < 130; i++)
            {
                Colour colour = (Colour)(new Random()).Next(0, 5);
                Console.WriteLine("The color is {0}", colour, Console.ForegroundColor);
            }
        }
    }

    public enum Colour
    {
        Red,
        Green,
        Blue,
        Purple,
        Yellow,
        Brown
    }
}
