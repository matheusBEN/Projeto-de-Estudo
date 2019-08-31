using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_01.Models
{
	[Table("Categories")]
	public class Categoria
	{
		[Column("CategoryId")]
		public int CategoriaId { get; set; }

		[Column("CategoryName")]
		public string Nome { get; set; }

	}

	

}