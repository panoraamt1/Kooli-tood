using System.Data;

namespace MethodCallTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number!");
            int nr = Convert.ToInt32(Console.ReadLine());

            if (int.IsEvenInteger(nr))
            {
                EvenNumbers(nr);
            }

            else
            {
                OddNumbers(nr);
            }

            static void OddNumbers(int nr)
            {
                Console.WriteLine("Tegemist on paaris arvuga" + nr);
            }

            static void EvenNumbers(int nr)
            {
                Console.WriteLine("Tegemist on paaritu arvuga" + nr);
            }
        }
    }

}
