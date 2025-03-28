﻿namespace ListForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Autoosade list");
            var parts = new List<CarPart>()
            {
                new CarPart() {Id = 1, PartName = "crank arm"},
                new CarPart() {Id = 2, PartName = "chane ring"},
                new CarPart() {Id = 3, PartName = "regular seat"},
                new CarPart() {Id = 4, PartName = "banana seat"},
                new CarPart() {Id = 5, PartName = "cassette"},
                new CarPart() {Id = 6, PartName = "shift lever"}
            };

            foreach (var part in parts)
            {
                Console.WriteLine(part.Id + " " + part.PartName);
            }
        }

        public class CarPart
        {
            public int Id { get; set; }
            public string PartName { get; set; }
        }
    }
}
