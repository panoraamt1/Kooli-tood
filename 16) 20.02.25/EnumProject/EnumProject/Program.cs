using System.Numerics;
using System.Reflection.Emit;

namespace EnumProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum!");

            Weekdays myVar = Weekdays.Monday;
            Console.WriteLine(myVar);

            Console.WriteLine("Valige päev 1-7.");
            string myday = System.Console.ReadLine();
            Weekdays day = (Weekdays)Convert.ToInt32(myday);

            System.Console.WriteLine(day);

            int color = (int)Colors.Yellow;
            Console.WriteLine(color);
        }

        enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Colors
        {
            Red = 3,
            Green = 10,
            Blue = 13,
            Yellow = 5,
            Black = 1
        }
    }
}
