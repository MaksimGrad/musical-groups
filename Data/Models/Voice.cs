using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalGroup.Data.Models
{
    public class Voice
    {
        public int Id { get; set; }
        public int? LoggingId { get; set; }
        public int? SongId { get; set; }
    }
}
