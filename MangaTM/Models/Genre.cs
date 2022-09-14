namespace MangaTM.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string GenreName { get; set; }
        public List<MangaGenre> MangaGenres { get; set; }

    }
}
