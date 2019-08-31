using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Impacta.MOD
{
	public class Editora
	{
		[Display (Name ="CODIGO DA EDITORA")]
		public int EditoraId { get; set; }

		[Display(Name ="RAZAO SOCIAL")]
		[Required(ErrorMessage ="Razão social deve ser informada")]
		public string Nome { get; set; }

		[EmailAddress]
		[Required(ErrorMessage ="E-mail de contato não esta sendo informado")]
		public string Email { get; set; }

		[Required]
		public string Cnpj { get; set; }

		[Phone]
		public string Telefone { get; set; }

		public Endereco Endereco { get; set; }

	
	}
}
