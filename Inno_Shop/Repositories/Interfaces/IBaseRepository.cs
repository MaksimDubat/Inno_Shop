using Inno_Shop.Entities;

namespace Inno_Shop.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс универсального репозитория по работе с моделью.
    /// </summary>
    /// <typeparam name="TDbModel"></typeparam>
    public interface IBaseRepository<TDbModel> where TDbModel : BaseModel
    {
        /// <summary>
        /// Получение моделей.
        /// </summary>
        /// <returns></returns>
        public List<TDbModel> GetAll();
        /// <summary>
        /// ПОлучение модели по идентификатору.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TDbModel GetById(int id);
        /// <summary>
        /// Создаение модели.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TDbModel Creat(TDbModel model);
        /// <summary>
        /// Обновление модели.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TDbModel Update(TDbModel model);
        /// <summary>
        /// Удаление модели.
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id);
    }
}
