using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Impacta.MOD
{
    public class Usuario
    {
        [Required (ErrorMessage ="Nome do usuario é obrigatorio")]
        [Display(Name ="USUARIO:")]
        [StringLength(8, MinimumLength = 5, ErrorMessage =("Usuario deve conter entre 5 e 8 caracteres"))]
        public string Username { get; set; }

        [Display(Name ="SENHA:")]
        [Required(ErrorMessage ="Senha é obrigatoria")]
        public string Password { get; set; }
    }
}
