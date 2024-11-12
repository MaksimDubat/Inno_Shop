namespace Inno_Shop.Entities
{
    /// <summary>
    /// Сущность взаимодействия с продуктом.
    /// </summary>
    public class ProductLogs : BaseModel
    {
        /// <summary>
        /// Идентификатор действия.
        /// </summary>
        public int Log_id { get; set; }
        /// <summary>
        /// Идентификатор продукта.
        /// </summary>
        public int Product_id { get; set; }
        /// <summary>
        /// Действие.
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// Время совершения действия.
        /// </summary>
        public DateTime Time_at { get; set; }
    }
}
