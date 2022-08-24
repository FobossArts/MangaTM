namespace MangaTM.Models
{
    public class Type
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public List<MangaType> MangaTypes { get; set; }

    }
}
