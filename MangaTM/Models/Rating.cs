namespace MangaTM.Models
{
    public class Rating
    {
        public Guid Id { get; set; }
        public Guid MangaId { get; set; }
        public Manga Manga { get; set; }
        public int Rate { get; set; }

    }
}
