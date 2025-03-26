using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipWhile
{
    class PeopleList
    {
        //Koostab nimekirja inimestest
        public static readonly List<People> people = new List<People>
        {
            // new People() lisab uue isiku andmed nimekirja
            new People()
            {
                Id = 1,
                FirstName = "Joonas",
                LastName = "Sepp",
                Age = 33,
                GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e")
            },
            new People()
            {
                Id = 2,
                FirstName = "Moona",
                LastName = "Kivimäe",
                Age = 24,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 3,
                FirstName = "Ron",
                LastName = "Weasly",
                Age = 19,
                GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e")
            },
            new People()
            {
                Id = 4,
                FirstName = "Mari",
                LastName = "Maasikas",
                Age = 16,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 5,
                FirstName = "Mari",
                LastName = "Sepp",
                Age = 27,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 6,
                FirstName = "Mick",
                LastName = "Toomsalu",
                Age = 30,
                GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e")
            },
            new People()
            {
                Id = 7,
                FirstName = "Jane",
                LastName = "Doe",
                Age = 20,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 8,
                FirstName = "Jane",
                LastName = "Foster",
                Age = 50,
                GenderId = Guid.Parse("c991bde5-dade-4b34-8acc-39381c95a1a7")
            },
            new People()
            {
                Id = 9,
                FirstName = "Callid",
                LastName = "Perkmen",
                Age = 35,
                GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e")
            },
            new People()
            {
                Id = 10,
                FirstName = "Aivo",
                LastName = "Pärt",
                Age = 20,
                GenderId = Guid.Parse("438ab9c9-b7a5-4fa7-be53-8bac6f7dd14e")
            },
        };
    }
}
