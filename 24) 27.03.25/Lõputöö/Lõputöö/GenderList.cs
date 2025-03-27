using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lõputöö
{
    public class GenderList
    {
        public static readonly List<Gender> genderList = new List<Gender>
        {
            new Gender()
            {
                GId = Guid.Parse("9df54680-4f76-4c26-a55a-92cf012fa71b"),
                GenderName = "male"
            },
            new Gender()
            {
                GId = Guid.Parse("fe7f4110-d1b9-4ebc-8219-b48c852be3e6"),
                GenderName = "female"
            }
        };
    }
}
