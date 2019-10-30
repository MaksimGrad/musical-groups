using Microsoft.EntityFrameworkCore;
using MusicalGroup.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace MusicalGroup.ViewModels
{
    public class SongsListViewModel
    {
        public Dictionary<int?, Song> AllSongs { get; set; }
        public IQueryable<SongVoices> AllSongsWithVoices { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string Image { get; set; }
        public string FilePath { get; set; }
        //public string GroupName { get; set; }
    }
}
