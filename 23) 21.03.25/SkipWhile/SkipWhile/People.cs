using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipWhile
{
    public class People
    {
        //Võtab andmed PeopleList klassist ja seob need allolevate rühmadega
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Guid GenderId { get; set; }
    }
}
