namespace MangaTM.Models
{
    public class Rating
    {
        public Guid Id { get; set; }
        public Guid IdManga { get; set; }
        public int Rate { get; set; }

    }
}
