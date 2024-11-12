using Inno_Shop.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inno_Shop.Database
{
    /// <summary>
    /// Контекст для работы таблицами.
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Контекст для работы таблицей Users.
        /// </summary>
        public DbSet<Users> Users { get; set; }
        /// <summary>
        /// Контекст для работы таблицей Products.
        /// </summary>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// Контекст для работы таблицей ProductsLogs.
        /// </summary>
        public DbSet<ProductLogs> ProductLogs { get; set; }
        /// <summary>
        /// Контекст для работы таблицей UserTokens.
        /// </summary>
        public DbSet<UserTokens> UserToken { get; set; }
        /// <summary>
        /// Контекст для работы таблицей EmailVerifications.
        /// </summary>
        public DbSet<EmailVerifications> EmailVerifications { get; set; }
        /// <summary>
        /// Контекст для работы таблицей PasswordsResets.
        /// </summary>
        public DbSet<PasswordReset> PasswordReset { get; set; }

        /// <summary>
        /// Конструктор с методом для проверки существования БД и ее создания при отсутствии.
        /// </summary>
        /// <param name="options"></param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
            Database.EnsureCreated();   
        }
    }
}
