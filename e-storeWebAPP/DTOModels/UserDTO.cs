using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.DTOModels
{
    public class UserDTO
    {

    }

    public class RegisterUserDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string JobTitle { get; set; }
    }

    public class LoginUserDTO
    {

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

    }

    public class ConfirmEmailUserDTO
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string UserId { get; set; }
    }

}
