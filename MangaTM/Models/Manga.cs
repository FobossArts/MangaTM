namespace MangaTM.Models
{
    public class Manga
    {
        public Guid Id { get; set; }
        public string MangaName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int ChapterCount { get; set; }
        //public bool StatusP { get; set; }
        //public bool StatusT { get; set; }
        public DateTime Date { get; set; }
        public string Allowance { get; set; }
        public List<MangaGenre> MangaGenres { get; set; }
        public List<TegManga> TegMangas { get; set; }
        public List<Mark> Marks { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Favouritie> Favourities { get; set; }
        public List<Commentarie> Commentaries { get; set; }
        public List<Chapter> Chapters { get; set; }

    }
}
