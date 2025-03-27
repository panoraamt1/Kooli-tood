namespace Lõputöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lõputöö!");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Valige soovitud meetodi number.");
            Console.WriteLine("1. Skip");
            Console.WriteLine("2. Join");
            Console.WriteLine("3. Salvesta tekst Arvuisse");
            Console.WriteLine("4. Numbri püramiid");
            Console.WriteLine("-----------------------");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Skip();
                break;
                case "2":
                    Join();
                break;
                case "3":
                    Writer();
                break;
                case "4":
                    Piramed();
                break;
                default:
                    Console.WriteLine("Vale valik");
                break;
            }
        }

        static void Skip()
        {
            Console.WriteLine("----------Skip---------");
            var skip = PeopleList.people.Skip(3);

            foreach (var x in skip)
            {
                Console.WriteLine(x.Id + ". " + x.Name);
            }
        }

        static void Join()
        {
            Console.WriteLine("----------Join---------");
            var innerJoin = PeopleList.people
                .Join
                (
                    GenderList.genderList,
                    humans => humans.GenderId,
                    gender => gender.GId,
                    (humans, gender) => new
                    {
                        Name = humans.Name,
                        GenderName = gender.GenderName,
                    }
                );

            foreach (var item in innerJoin)
            {
                Console.WriteLine("{0} - {1}", item.Name, item.GenderName);
            }
        }

        static void Writer()
        {       
            Console.WriteLine("Vali faili salvestus ketas. Kas C või W.");
            string drive = Console.ReadLine();
            drive = drive.ToUpper();
            if (drive == "C")
            {
                Console.WriteLine("--Kirjuta faili läbi konsooli--");

                string filePath = @"C:/Users/Opilane/Desktop/Written Text.txt";
                string inputText = Console.ReadLine();

                File.WriteAllText(filePath, inputText);
            }
            else if (drive == "W") 
            {
                try
                {
                    Console.WriteLine("--Kirjuta faili läbi konsooli--");

                    string filePath = @"W:/Users/Opilane/source/Written Text2.txt";
                    string inputText = Console.ReadLine();

                    File.WriteAllText(filePath, inputText);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Tekkis ERROR");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            else
            {
                Console.WriteLine("Valige antud ketaste vahel");
            }
        }
        static void Piramed()
        {
            Console.WriteLine("----------Numbripüramiid---------");

            Console.Write("\n\n");
            Console.WriteLine("Sisesta püramiidi suurus");
            int i, j, n;

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.Write("\n");
            }
        }
    }
}
