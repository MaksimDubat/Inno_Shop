namespace Inno_Shop.Entities
{
    /// <summary>
    ///  Сущность токенов для сброса паролей.
    /// </summary>
    public class PasswordReset : BaseModel
    {
        /// <summary>
        /// Идентификатор попытки сброса пароля.
        /// </summary>
        public int Reset_id { get; set; }
        /// <summary>
        /// Токен.
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// Время истечения срока токена.
        /// </summary>
        public DateTime expires_at { get; set; }
        /// <summary>
        /// Время создания токена.
        /// </summary>
        public DateTime created_at { get; set; }
    }
}
