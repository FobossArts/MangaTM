namespace MangaTM.Models
{
    public class MangaType
    {
        
        public Guid Id { get; set; }
        public Guid MangaId { get; set; }
        public Manga Manga { get; set; }
        public Guid TypeId { get; set; }
        public Type Type { get; set; }

    }
}
