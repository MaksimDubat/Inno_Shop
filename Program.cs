
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Inno_Shop
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        //����� �� �������������� �������� ��� ��������� ������
                        ValidateIssuer = true,
                        //��������
                        ValidIssuer = AuthOptions.ISSUER,
                        //����� �� �������������� ����������� ������
                        ValidateAudience = true,
                        //�����������
                        ValidAudience = AuthOptions.AUDIENCE,
                        //����� �� �������������� ����� �������������
                        ValidateLifetime = true,
                        //��������� ����� ������������
                        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                        //��������� ����� ������������ 
                        ValidateIssuerSigningKey = true,
                    };
                });

            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseAuthentication();
            app.UseAuthorization();

            app.Map("/login/{username}", (string username) =>
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, username) };
                var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(3)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
                return new JwtSecurityTokenHandler().WriteToken(jwt);
            });

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.MapControllers();
            app.Map("/data", [Authorize] () => new { message = "Good!" });

            app.Run();
        }
        public class AuthOptions
        {
            public const string ISSUER = "MyAuthServer"; // �������� ������
            public const string AUDIENCE = "MyAuthClient"; // ����������� ������
            const string KEY = "secretsecretsecretkey12345!"; // ���� ��� ��������
            public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
        }
    }
}
