namespace MangaTM.Models
{
    public class Chapter
    {
        public Guid Id { get; set; }
        public int MangaId { get; set; }
        public Manga Manga { get; set; }
        public string refer { get; set; }
    }
}
