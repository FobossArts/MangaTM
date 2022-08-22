namespace MangaTM.Models
{
    public class Commentarie
    {
        public Guid Id { get; set; }
        public DateTime DateCom { get; set; }
        public string Text { get; set; }
        public int MangaId { get; set; }
        public Manga Manga { get; set; }
    }
}
