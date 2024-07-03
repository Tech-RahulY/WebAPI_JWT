namespace WebAPI_JWT_Authorize.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }= string.Empty;
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
