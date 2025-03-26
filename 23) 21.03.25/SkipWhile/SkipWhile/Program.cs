namespace SkipWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Edastsb sõnumi
            Console.WriteLine("Skip While!");
            //Toob välja voidis olevad andmed, et oleks näha konsoolis
            SkipWhile();
            SkipWhileID();
            SkipWhileLast();
        }

        public static void SkipWhile()
        {
            Console.WriteLine("------------------------");
            //Jätab vahele inimesed nimekirjas, kuni leiab esimese inimese kelle vanus on väiksem sisestatud vanusest
            var skip = PeopleList.people.SkipWhile(x => x.Age > 17);
            //Kirjutab alloleva teksti iga allesjäänud inimese kohta
            foreach (var x in skip)
            {
                Console.WriteLine(x.Id + " " + x.FirstName + " " + x.LastName);
            }
        }

        public static void SkipWhileID()
        {
            Console.WriteLine("------------------------");
            //Jätab vahele inimesed nimekirjas, kuni leiab esimese inimese kelle id ei ole väiksem ja võrdne sisestatud numbrist
            var skip = PeopleList.people.SkipWhile(x => x.Id <= 5);
            //Kirjutab alloleva teksti iga allesjäänud inimese kohta
            foreach (var x in skip)
            {
                Console.WriteLine(x.Id + " " + x.FirstName + " " + x.LastName);
            }
        }
        public static void SkipWhileLast()
        {
            Console.WriteLine("------------------------");
            //Jätab vahele inimesed nimekirjas, kuni leiab esimese inimese kelle perekonnanime pikkus ei ole väiksem sisestatud numbrist
            var skip = PeopleList.people.SkipWhile(x => x.LastName.Length < 7);
            //Kirjutab alloleva teksti iga allesjäänud inimese kohta
            foreach (var x in skip)
            {
                Console.WriteLine(x.Id + " " + x.FirstName + " " + x.LastName);
            }
        }
    }
}
