namespace Inno_Shop.Services
{
    /// <summary>
    /// Интерфейс для создания токенов сброса паролей.
    /// </summary>
    public interface IUserService
    {
        Task<string?> ResetTokenAsync(string email);
        Task<bool> ResetPasswordAsync (string token, string newPassword);
    }
}
