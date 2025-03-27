using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lõputöö
{
    public class PeopleList
    {
        public static readonly List<People> people = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Jonathen",
                Age = 21,
                GenderId = Guid.Parse("9df54680-4f76-4c26-a55a-92cf012fa71b"),
            },
            new People()
            {
                Id = 2,
                Name = "Mona",
                Age = 18,
                GenderId = Guid.Parse("fe7f4110-d1b9-4ebc-8219-b48c852be3e6"),
            },
            new People()
            {
                Id = 3,
                Name = "Ronaldo",
                Age = 28,
                GenderId = Guid.Parse("9df54680-4f76-4c26-a55a-92cf012fa71b"),
            },
            new People()
            {
                Id= 4,
                Name = "Janet",
                Age = 33,
                GenderId = Guid.Parse("fe7f4110-d1b9-4ebc-8219-b48c852be3e6"),
            },
            new People()
            {
                Id= 5,
                Name = "Maria",
                Age = 15,
                GenderId = Guid.Parse("fe7f4110-d1b9-4ebc-8219-b48c852be3e6"),
            },
            new People()
            {
                Id= 6,
                Name = "Maria",
                Age = 17,
                GenderId = Guid.Parse("fe7f4110-d1b9-4ebc-8219-b48c852be3e6"),
            },
        };
    }
}
