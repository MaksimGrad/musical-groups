using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicalGroup.Data.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string Image { get; set; }
        public string FilePath { get; set; }
        public Repertoire Repertoire { get; set; }
    }
}
