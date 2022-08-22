using Microsoft.EntityFrameworkCore;

namespace MangaTM.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public DbSet<Manga> Mangas { get; set; } = null!;
        public DbSet<Type> Types { get; set; } = null!;
        public DbSet<MangaType> MangaTypes { get; set; } = null!;
        public DbSet<Teg> Tegs { get; set; } = null!;
        public DbSet<TegManga> TegMangas { get; set; } = null!;
        public DbSet<Rating> Ratings { get; set; } = null!;
        public DbSet<Mark> Marks { get; set; } = null!;
        public DbSet<Favouritie> Favourities { get; set; } = null!;
        public DbSet<Commentarie> Commentaries { get; set; } = null!;
        public DbSet<Chapter> Chapters { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
