namespace MangaTM.Models
{
    public class MangaType
    {
        
        public Guid Id { get; set; }
        public int MangaId { get; set; }
        public Manga Manga { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }

    }
}
