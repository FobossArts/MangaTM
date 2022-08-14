namespace MangaTM.Models
{
    public class Users
    {
        public Guid Id { get; set; }
        public Guid IdRole { get; set; }
        public string Name { get; set; }    
        public string Login { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; } // знак вопроса вроде допускает значения null, то есть пользователь может пропустить эмэйл при регистрации
        //public int Age { get; set; } // будет манга 18+ проверка по возрасту, как идея, потом скажешь



    }
}
