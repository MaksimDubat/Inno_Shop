namespace Inno_Shop.Entities
{
    /// <summary>
    /// Сущность для хранения токена доступа.
    /// </summary>
    public class UserTokens : BaseModel
    {
        /// <summary>
        /// Уникальный идентификатор токена.
        /// </summary>
        public int Token_id { get; set; }
        /// <summary>
        /// Токен доступа.
        /// </summary>
        public string Token {  get; set; }
        /// <summary>
        /// Время истечения токена.
        /// </summary>
        public DateTime Expiries_at { get; set; }
        /// <summary>
        /// Время создания токена.
        /// </summary>
        public DateTime Created_at { get; set;}

    }
}
