namespace IfElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roll your dice.");

            Random rnd = new Random();
            int dTwenty = rnd.Next(1, 21);
            int dSix = rnd.Next(1, 7);

            if (dTwenty == 1)
            {
                Console.WriteLine("A nat 1. You die of death.");
            }

            else if (dTwenty > 1 && dTwenty < 11)
            {
                Console.WriteLine("You rolled a " + dTwenty+ ". Roll a saving throw.");

                if (dSix == 6)
                {
                    Console.WriteLine("You live, barely.");
                }

                else
                {
                    Console.WriteLine("You take to much damage and die.");
                }
            }

            else if (dTwenty > 10 && dTwenty < 20)
            {
                Console.WriteLine("You rold a " +dTwenty+ ". Roll for damage.");
                if (dSix >= 5)
                {
                    Console.WriteLine("You die.");
                }

                else
                {
                    Console.WriteLine("You survive.");
                }
            }

            else
            {
                Console.WriteLine("A nat 20. You avoide all damage.");
            }
        }
    }
}
