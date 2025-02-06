namespace Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Brackets!");

            Console.WriteLine("Kui palju on 3 + 8 / ( 4 - 2 ) * 4 = ?");
            //Kui tahad komakohta siis pane lõppu .0
            double calc1 = 3 + 8 / (4 - 2) * 4;
            double calc2 = (3 + (8 / ((4 - 2) * 4)));

            Console.WriteLine("Vastus: " + calc1);
            Console.WriteLine("Vastus: " + calc2);

            double firstNr = 100;
            double secondNr = 75;
            double thirdNr = 50;

            double anwser = firstNr / (secondNr * thirdNr); 

            Console.WriteLine(anwser);
        }
    }
}
