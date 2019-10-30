using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicalGroup.Data.Models;
using MusicalGroup.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalGroup.Controllers
{
    public class HomeController : Controller
    {
        private MusicStoreContext db;
        public HomeController(MusicStoreContext context)
        {
            db = context;
        }

        [Authorize]
        public ViewResult Index()
        {
            SongsListViewModel model = new SongsListViewModel();
            Dictionary<int, Song> allSongs = db.Songs
                .Include(s => s.Repertoire)
                .ThenInclude(r => r.Group)
                .ToDictionary(k => k.Id);
            model.AllSongsWithVoices = db.Voices
                .GroupBy(v => v.SongId)
                .Select(g => new SongVoices { Song = allSongs[(int)g.Key], CountVoices = g.Count() })
                .OrderByDescending(v => v.CountVoices);

            return View(model);
        }

        public async Task<RedirectResult> Voiting(int _songId)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Login == User.Identity.Name);
            Logging logging = await db.Logging.LastOrDefaultAsync(u => u.UserId == user.Id);
            Voice voice = new Voice() { LoggingId = logging.Id, SongId = _songId };
            db.Voices.Add(voice);
            db.SaveChanges();

            return Redirect("/");
        }
    }
}
