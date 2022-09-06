namespace MangaTM.Models
{
    public class TegManga
    {
        public Guid Id { get; set; }
        public Guid MangaId { get; set; }
        public Manga Manga { get; set; }
        public Guid TegId { get; set; }
        public Teg Teg { get; set; }

    }
}
