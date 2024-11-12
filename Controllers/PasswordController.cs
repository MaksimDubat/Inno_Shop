using Inno_Shop.Entities;
using Inno_Shop.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inno_Shop.Controllers
{
    public class PasswordController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;

        public PasswordController(IUserService userService, IEmailService emailService)
        {
            _userService = userService;
            _emailService = emailService;
        }

        [HttpPost("forgotPassowrd")]
        public async Task<IActionResult> ForgotPassword([FromBody] PasswordReset reset)
        {
            var token = await _userService.ResetTokenAsync(reset.Email);
            if (token == null) 
            {
                return BadRequest("Неверный email");
            }
            await _emailService.SendPasswordAsync(reset.Email, token);
            return Ok("отрпавлено для сброса");
        }

        [HttpPost("resetpassword")]
        public async Task<IActionResult> ResetPassword([FromBody] NewPassword reset)
        {
            var result = await _userService.ResetPasswordAsync(reset.Token, reset.UpdatedPassword);
            if (result)
            {
                return Ok("готово");
            }
            return BadRequest("ошибка");
        }
    }
}
