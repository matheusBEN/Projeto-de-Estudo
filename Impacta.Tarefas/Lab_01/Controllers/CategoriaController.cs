using Lab_01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_01.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
			var db = new CategoriaDb();
			var lista = db.CategoriasLista();

            return View(lista);
        }

		public ActionResult ProdutosPorCategoria(int id)
		{
			var db = new CategoriaDb();
			var lista = db.ProdutosPorCategoria(id);
			var categoria = db.CategoriaObter(id);
			ViewBag.CategoriaNome = categoria.Nome;
			return View(lista);
		}
	}
}