namespace MangaTM.Models
{
    public class Favourities
    {
        // избранное
        public Guid Id { get; set; }
        public Guid IdManga { get; set; }
        public bool Status { get; set; }
        //public int Chapter { get; set; } думаю лишнее, в избранных нет главы
    }
}
