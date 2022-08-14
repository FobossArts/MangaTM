namespace MangaTM.Models
{
    public class Manga
    {
        public Guid Id { get; set; }
        public string MangaName { get; set; }
        public int ChapterCount { get; set; }
        public bool StatusP { get; set; }
        public bool StatusT { get; set; }
        public DateTime Date { get; set; }
        public string Allowance { get; set; }

    }
}
