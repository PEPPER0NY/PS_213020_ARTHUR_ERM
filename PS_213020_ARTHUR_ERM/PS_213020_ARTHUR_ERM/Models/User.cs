using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS_213020_ARTHUR_ERM.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public DateTime Date_of_brith { get; set; }
        public byte[] Avatar { get; set; }


    }
}
