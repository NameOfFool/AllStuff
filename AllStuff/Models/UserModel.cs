using System.ComponentModel.DataAnnotations;

namespace AllStuff.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public UserModel(int id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }
    }
}
