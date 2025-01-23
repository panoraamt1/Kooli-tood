namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Pleas enter 1 or 2!");

            try
            {
                int num = int.Parse(Console.ReadLine());


                switch (num)
                {
                    case 1:
                        Console.WriteLine("You chouse nr 1.");
                        break;
                    case 2:
                        Console.WriteLine("You chouse nr 2.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Not a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error! Number to big.");
            }
        }
    }
}
