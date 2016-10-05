using System.Data.Entity;

namespace MVC_music_store.Models
{
    public class MusicStoreEntities : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MVC_music_store.Models.Artist> Artists { get; set; }
    }
}