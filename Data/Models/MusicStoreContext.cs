using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MusicalGroup.Data.Models
{
    public class MusicStoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Repertoire> Repertoires { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Logging> Logging { get; set; }
        public DbSet<Voice> Voices { get; set; }

        public MusicStoreContext(DbContextOptions<MusicStoreContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
