using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalGroup.Data.Models
{
    public class Logging
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime SignOutDatetime { get; set; }
    }
}
