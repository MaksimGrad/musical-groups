
using System.Collections.Generic;

namespace MusicalGroup.Data.Models
{
    public class Repertoire
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int? SongId { get; set; }
        public Song Song { get; set; }
        public Group Group { get; set; }

        public Repertoire()
        {
            Song = new Song();
            Group = new Group();
        }
    }
}
