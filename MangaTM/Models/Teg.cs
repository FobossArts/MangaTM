namespace MangaTM.Models
{
    public class Teg
    {
        public Guid Id { get; set; }
        public string TegName { get; set; }
        public List<TegManga> TegMangas { get; set; }
    }
}
