using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_01.Models
{
	[Table("Products")]
	public class Produto
	{
		[Column("ProductId")]
		public int ProdutoId { get; set; }

		[Column("ProductName")]
		public string Nome { get; set; }

		[Column("UnitPrice")]
		public decimal Preco { get; set; }

		[Column("UnitInStock")]
		public short Estoque { get; set; }

		[ForeignKey("Categoria")]
		[Column("CategoryId")]
		public int CategoriaId { get; set; }

		public Categoria Categoria { get; set; }
	}
}