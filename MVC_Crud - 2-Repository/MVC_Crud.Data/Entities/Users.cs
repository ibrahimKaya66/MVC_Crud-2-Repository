using MVC_Crud.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Crud.Data.Entities
{
    public class Users: BaseEntity
    {
        //[Required]//Username için kullanılması zorunlu alan
        [Required(ErrorMessage ="Kullanıcı Adı Boş Geçilemez!!!")]
        public string Username { get; set; }

        //[Required]//Username için kullanılması zorunlu alan
        [Required(ErrorMessage = "Şifre Boş Geçilemez!!!")]
        public string Pass { get; set; }
    }
}
