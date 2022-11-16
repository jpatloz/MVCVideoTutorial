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

            //ViewBag.ListaUsuarios = listaUsuarios; //No puede pasar información de un controlador a otro, solo del controlador a las vistas
            //TempData["ListaUsuarios"] = listaUsuarios; //Solo puede mandar la información una vez
            //Session["ListaUsuarios"] = listaUsuarios; //Envía la información entre ontroladores hasta que caduque la sesión
            ViewData["ListaUsuarios"] = listaUsuarios; //Es muy similar al ViewBag pero necesita un casting


            return View(listaUsuarios);
        }

        [HttpPost]
        public ActionResult ListaUsuarios(string selUsuarios)
        {
            ViewBag.Nombre = selUsuarios;
            //List<string> listaUsuarios = ViewBag.ListaUsuarios;
            //List<string> listaUsuarios = (List<string>)TempData["ListaUsuarios"];//Es necesario hacer un casting en posibles correciones
            //List<string> listaUsuarios = (List<string>)Session["ListaUsuarios"];
            List<string> listaUsuarios = (List<string>)ViewData["ListaUsuarios"];
            return View(listaUsuarios);
        }

    }
}