namespace Inno_Shop.Entities
{
    public class NewPassword : BaseModel
    { 
        public string Token { get; set; }
        public string UpdatedPassword { get; set; }
    }
}
