﻿namespace MangaTM.Models
{
    public class Mark
    {
        // закладка
        public Guid Id { get; set; }
        public int MangaId { get; set; }
        public Manga Manga { get; set; }
        public int Chapter { get; set; }
        public int Page { get; set; }
    }
}
