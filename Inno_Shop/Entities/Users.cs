namespace Inno_Shop.Entities
{
    /// <summary>
    /// Сущность пользователя.
    /// </summary>
    public class Users : BaseModel
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Email пользователя.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Пароль пользователя.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Роль пользователя.
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// Статус активности пользователя
        /// </summary>
        public bool Is_active { get; set; } = true;
    }
}
