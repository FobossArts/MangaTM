namespace MangaTM.Models
{
    public class Favouritie
    {
        // избранное
        public Guid Id { get; set; }
        public int MangaId { get; set; }
        public Manga Manga { get; set; }
        public bool Status { get; set; }
    }
}
