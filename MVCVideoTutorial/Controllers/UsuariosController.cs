using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCVideoTutorial.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaUsuarios()
        {
            List<string> listaUsuarios = new List<string>();
            listaUsuarios.Add("Jesus");
            listaUsuarios.Add("Pablo");
            listaUsuarios.Add("Mena");
            listaUsuarios.Add("Juanca");
            listaUsuarios.Add("Javi");
            return View(listaUsuarios);
        }
    }
}