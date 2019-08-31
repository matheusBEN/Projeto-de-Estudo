using Lab_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_01.DAL
{
	public class CategoriaDb
	{
		//Categorias Lista
		//retorna  a lista de categorias

		public List<Categoria> CategoriasLista()
		{
			using (var db = new NorthwindContext())
			{
				return db.Categorias.ToList();

			}
		}

		public List<Produto> ProdutosPorCategoria(int categoriaId)
		//Produtos por Categoria
		// retorna uma lista de produtos de uma categoria
		{
			using (var db = new NorthwindContext())
			{
				var query = from c in db.Produtos
							where c.CategoriaId == categoriaId
							select c;
				var lista = query.ToList();

				return lista;
			}

		}

		public Categoria CategoriaObter(int id)
		{
			using (var db = new NorthwindContext())
			{
				return db.Categorias.Where(m => m.CategoriaId == id).FirstOrDefault();
			}
		}

	}
}