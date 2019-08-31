using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Impacta.MOD;
using System.Web.Security;

namespace Impacta.Tarefas.Controllers
{
    
    public class LoginController : Controller
    {
        [Authorize]
        // GET: Login
        public ActionResult Autenticacao()
        {
            Usuario usuario = null;

            return View(usuario);
        }

        public ActionResult AutenticarLogin(Usuario usuario)
        {
            FormsAuthentication.SetAuthCookie(usuario.Username, false);

            return RedirectToAction("Index", "RealBooks");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return View("AutenticarLogin");
        }
    }
}