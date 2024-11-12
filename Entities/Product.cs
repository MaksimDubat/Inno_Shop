namespace Inno_Shop.Entities
{
    /// <summary>
    /// Сущность продукта.
    /// </summary>
    public class Product : BaseModel
    {
        /// <summary>
        /// Идентификатор продукта.
        /// </summary>
        public int Product_id { get; set; }
        /// <summary>
        /// Наименование продукта.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание продукта.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Цена продукта.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Доступен ли товар.
        /// </summary>
        public bool IS_available { get; set; } = true;
        /// <summary>
        /// Активен ли товар.
        /// </summary>
        public bool Is_active { get; set; } = true;
    }
}
