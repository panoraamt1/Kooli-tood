namespace IfAndElseAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta vanus!");

            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age < 0)
            {
                Console.WriteLine("Error.");
            }

            else if (Age < 18)
            {
                Console.WriteLine("Oled alaealine.");
            }

            else if (Age >= 18 && Age < 65)
            {
                Console.WriteLine("Oled täisealine.");
            }

            else
            {
                Console.WriteLine("Oled pensionäär.");
            }
        }
    }
}
