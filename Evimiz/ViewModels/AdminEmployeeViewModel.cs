using Evimiz.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.ViewModels
{
    public class AdminEmployeeViewModel
    {
        [Required(ErrorMessage = "İstifadəçi adınızı daxil edin"), StringLength(100, ErrorMessage = "İstifadəçi adınız 100 hərfden artıq ola bilməz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Emailinizi daxil edin"), EmailAddress(ErrorMessage = "Düzgun email daxil edin"), DataType(DataType.EmailAddress, ErrorMessage = "Düzgun email daxil edin")]
        public string Email { get; set; }

        [Required(ErrorMessage = "İstifadəçi parolunuzu daxil edin"), DataType(DataType.Password, ErrorMessage = "Düzgün şifrə qəbul edin")]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Təsdiq şifrəniz şifrə ilə eyni olmalıdır")]
        [Required(ErrorMessage = "Təsdiq parolunuzu daxil edin"), DataType(DataType.Password, ErrorMessage = "Düzgün şifrə qəbul edin")]
        public string ConfirePassword { get; set; }



        public string RoleId { get; set; }
    }
}
