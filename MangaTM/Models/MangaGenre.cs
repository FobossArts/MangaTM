namespace MangaTM.Models
{
    public class MangaGenre
    {
        
        public Guid Id { get; set; }
        public Guid MangaId { get; set; }
        public Manga Manga { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}
