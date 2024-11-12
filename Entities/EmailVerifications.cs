namespace Inno_Shop.Entities
{
    /// <summary>
    /// Сущность для подтверждения Email.
    /// </summary>
    public class EmailVerifications : BaseModel
    {
        /// <summary>
        /// Уникальный идентификатор попытки.
        /// </summary>
        public int Verification_id { get; set; } 
        /// <summary>
        /// Токен.
        /// </summary>
        public string Token { get; set; }   
    }
}
