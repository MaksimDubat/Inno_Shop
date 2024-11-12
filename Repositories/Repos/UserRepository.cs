using Inno_Shop.Database;
using Inno_Shop.Entities;
using System.Linq;

namespace Inno_Shop.Repositories.Repos
{
    public class UserRepository : BaseRepository<Users>
    {
        public UserRepository(ApplicationContext _context) : base(_context) { }

        public Users CreateUser (Users newUser)
        {
            if (newUser == null)
            {
                throw new ArgumentNullException(nameof(newUser));
            }
            if (context.Users.Any(u => u.Email == newUser.Email))
            {
                throw new InvalidOperationException("Пользователь с таким email существует");
            }
            context.Users.Add(newUser);
            context.SaveChanges();
            return newUser;
        }

        public List<Users> GetAllUsers()
        {
            return context.Users.ToList(); 
        }

        public Users GetUserById(int id)
        {
            return context.Users.FirstOrDefault(u => u.User_id == id);
        }
      
        public Users UpdateUser (Users updateUser)
        {
            if (updateUser == null)
            {
                throw new ArgumentNullException(nameof(updateUser));
            }
            var user = context.Users.FirstOrDefault( u => u.User_id == updateUser.User_id);
            if (user != null) 
            {
                user.Name = updateUser.Name;
                user.Email = updateUser.Email;
                user.Role = updateUser.Role;
                user.Is_active= updateUser.Is_active;

                context.SaveChanges();
            }
            return user;
        }
        public void DeleteUser(int id)
        {
            var user = context.Users.FirstOrDefault(u => u.User_id == id);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
    }
}
