using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace DiceRollGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu veeretamine");
            var values = new List<object>();
            for (int ctr = 0; ctr <= 7; ctr++)
            {
                if (ctr == 2)
                {
                    values.Add(DiceLibrary.Roll2());
                }

                else if (ctr == 4)
                {
                    values.Add(DiceLibrary.Pass());
                }

                else
                {
                    values.Add(DiceLibrary.Roll());
                }
            }
            Console.WriteLine($"The sum of {values.Count} die is" + $" {DiceLibrary.DiceSum}");
        }
    }

    public static class DiceLibrary
    {
        static Random rnd = new Random();
        public static int Roll()
        {
            return rnd.Next(1, 7);
        }
        public static List<object> Roll2()
        {
            var rolls = new List<object>();
            rolls.Add(Roll());
            rolls.Add(Roll());
            return rolls;
        }

        public static int DiceSum(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                switch (value)
                {
                    case 0:
                    break;

                    case int val:
                        sum += val;
                    break;

                    case IEnumerable<object> sublist when sublist.Any():
                        sum += DiceSum(sublist);
                    break;

                    case IEnumerable<object> sublist:
                    break;

                    case null:
                    break;

                    default:
                        throw new InvalidOperationException("unknown item type");
                    
                }
            }
            return sum;
        }

        public static object Pass()
        {
            if (rnd.Next(0, 2) == 0)
            {
                return null;
            }
            else
            {
                return new List<object>();
            }
        }
    }
}
