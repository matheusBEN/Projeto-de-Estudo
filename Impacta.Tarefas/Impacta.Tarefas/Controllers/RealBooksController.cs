using Impacta.MOD;
using Impacta.Tarefas.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Impacta.Tarefas.Controllers
{
    public class RealBooksController : Controller
    {
        // GET: RealBooks
        public ActionResult Index()
        {
			return View();
        }

		public ActionResult ListarNovasEditora()
		{
			try
			{
				EditoraBUS objEditora = new EditoraBUS();

				var lst = objEditora.ListarEditoras();

				return View(lst);

			}
			catch (Exception)
			{

				throw;
			}


			

		}

		// GET: RealBooks/Details/5
		public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RealBooks/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: RealBooks/Create
        [HttpPost]
        public ActionResult Create(Editora collection)
        {
            try
            {

				EditoraBUS editoraBus = new EditoraBUS();

				editoraBus.Salvar(collection);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RealBooks/Edit/5
        public ActionResult Edit(int id)
        {
			try
			{
				if (!ModelState.IsValid)
				{
					ModelState.AddModelError("Editora", "Editora invalida.");
				}
				EditoraBUS objEditora = new EditoraBUS();

				var lst = objEditora.BuscarEditora(id);

				return View(lst);

			}
			catch
			{

				return View();
			}
            
        }

        // POST: RealBooks/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RealBooks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RealBooks/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
