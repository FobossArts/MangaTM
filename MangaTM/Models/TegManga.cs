namespace MangaTM.Models
{
    public class TegManga
    {
        public Guid Id { get; set; }
        public int MangaId { get; set; }
        public Manga Manga { get; set; }
        public int TegId { get; set; }
        public Teg Teg { get; set; }

    }
}
