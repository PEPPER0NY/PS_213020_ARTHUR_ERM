using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS_213020_ARTHUR_ERM.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CretaeDate { get; set; }
        public DateTime? ChangeDate { get; set; }

    }
}
