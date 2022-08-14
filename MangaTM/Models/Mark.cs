namespace MangaTM.Models
{
    public class Mark
    {
        // закладка
        public Guid Id { get; set; }
        public Guid IdManga { get; set; }
        public int Chapter { get; set; }
        public int Page { get; set; }
    }
}
