﻿namespace MangaTM.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public List<User> Users { get; set; }
    }
}
