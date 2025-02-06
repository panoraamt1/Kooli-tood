namespace SwitchTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            const int one = 1, two = 2, five = 5, ten = 10, twenty = 20, fifty = 50;
            Console.WriteLine("Sisesta jagatavate sentide väärtus.");
            int midSum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vajuta number 1 ja enter.");
            int amoCent = 0;
            string sum = Console.ReadLine();

            switch (sum)
            {
                case "1":
                    amoCent = midSum / fifty;
                    Console.WriteLine("50-sendiseid: "+ amoCent + " tk");

                    midSum = midSum - amoCent * fifty;
                    amoCent = midSum / twenty;
                    Console.WriteLine("20-sendiseid: " + amoCent + " tk");

                    midSum = midSum - amoCent * twenty;
                    amoCent = midSum / ten;
                    Console.WriteLine("10-sendiseid: " + amoCent + " tk");

                    midSum = midSum - amoCent * ten;
                    amoCent = midSum / five;
                    Console.WriteLine("5-sendiseid: " + amoCent + " tk");

                    midSum = midSum - amoCent * five;
                    amoCent = midSum / two;
                    Console.WriteLine("2-sendiseid: " + amoCent + " tk");

                    midSum = midSum - amoCent * two;
                    amoCent = midSum / one;
                    Console.WriteLine("1-sendiseid: " + amoCent + " tk");
                    break;
            }
        }
    }
}
