namespace AroundWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            double coinDiameter = 25.75; //mm
            double EarthRadious = 6378000000; //mm
            double arroundEarth = 2 * Math.PI * EarthRadious;

            Console.WriteLine("Maa ümbermõõt: " + arroundEarth);

            double coinsEarth = arroundEarth / coinDiameter;

            Console.WriteLine("Münte vaja maakera ümber minemiseks: " + coinsEarth);  
        }
    }
}
