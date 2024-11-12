namespace Inno_Shop.Services
{
    /// <summary>
    /// Интерфейс для отправки ссылки для сброса.
    /// </summary>
    public interface IEmailService
    {
        Task SendPasswordAsync (string email, string password);
    }
}
