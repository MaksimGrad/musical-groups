using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicalGroup.Data.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public Repertoire Repertoire { get; set; }
    }
}
