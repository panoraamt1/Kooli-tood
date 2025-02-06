namespace StringLengthCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] animalName = { "Koer", "Kass", "Jänes", "Sipelgasiil", "Lendorav" };
            int len = animalName[0].Length;
            string lenString = animalName[0];

            for (int i =0; i<animalName.Length; i++)
            {
                if (len < animalName[i].Length)
                {
                    len = animalName[i].Length;
                    lenString = animalName[i];
                }
                int animalLen = lenOfAnim(animalName[i]);
                Console.WriteLine(animalName[i] + " = ");
                Console.WriteLine(animalLen);
            }
            Console.WriteLine("Pikkim nimi oli {0} ja nime pikkus oli {1}", len, lenString);

        }
        static int lenOfAnim(string animalName)
        {
            return animalName.Length;
        }
    }
}
