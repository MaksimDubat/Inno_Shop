using Inno_Shop.Database;
using Inno_Shop.Entities;
using Inno_Shop.Repositories.Interfaces;

namespace Inno_Shop.Repositories.Repos
{
    /// <summary>
    /// Реализация интерфейса IBaseRepository.
    /// </summary>
    /// <typeparam name="TDbModel"></typeparam>
    public class BaseRepository<TDbModel> : IBaseRepository<TDbModel> where TDbModel : BaseModel
    {
        protected ApplicationContext context { get; set; }
        public BaseRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public TDbModel Creat(TDbModel model)
        {
            context.Set<TDbModel>().Add(model);
            context.SaveChanges();
            return model;
        }

        public void Delete(int id)
        {
            var toDelete = context.Set<TDbModel>().Find(id);
            if (toDelete != null) 
            {
                context.Set<TDbModel>().Remove(toDelete);
                context.SaveChanges();
            }
        }


        public List<TDbModel> GetAll()
        {
            return context.Set<TDbModel>().ToList();
        }

        public TDbModel GetById(int id)
        {
            return context.Set<TDbModel>().Find(id); 
        }

        public TDbModel Update(TDbModel model)
        {
            var toUpdate = context.Set<TDbModel>().Find(model.User_id);
            if (toUpdate != null) 
            {
                toUpdate = model;
            }
            context.Update(toUpdate);
            context.SaveChanges();
            return toUpdate;
        }
    }


}
