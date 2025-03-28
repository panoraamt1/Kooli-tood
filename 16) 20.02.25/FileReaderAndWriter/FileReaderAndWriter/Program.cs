namespace FileReaderAndWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ReaderAndWriter();
        }

        static void ReaderAndWriter()
        {
            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/Administrator/Desktop/Nimed.txt"))
                {
                    string rida = sr.ReadToEnd();
                    string[] nimed = rida.Split('\n');

                    foreach (string name in nimed)
                    {
                        Console.WriteLine(name);
                    }
                    sr.Close();

                    using (StreamWriter write = new StreamWriter("C:/Users/Administrator/Desktop/tuttavd1.txt", true))
                    {
                        Array.Sort(nimed);
                        int i = 1;
                        Console.WriteLine("Sorteeritud");
                        foreach (var name in nimed)
                        {
                            write.WriteLine(i + " " + name);
                            i++;
                        }
                    }
                    

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
