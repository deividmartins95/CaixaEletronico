using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAO;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ClienteController : Controller
    {

        private static List<Usuario> clientes = new List<Usuario>();

        public ActionResult Form()
        {
            return View();
        }

        [HttpGet]
        public List<Usuario> Lista()
        {
            return clientes;
        }

        [HttpPost] 
      
        public ActionResult Cadastrar(Cliente clientes)
        {
            ClientesDAO dao = new ClientesDAO();
            dao.Cadastrar(clientes);
            return RedirectToAction("Index", "Operacoes");

        }
       
      
        public ActionResult VisualizaCliente(int NuConta)
        {
            ClientesDAO dao = new ClientesDAO();
            Cliente clientes = dao.BuscaPorConta(NuConta);
            ViewBag.Cliente = clientes;
            return View();
        }
        public ActionResult Remove(int NuConta)
        {

            ClientesDAO dao = new ClientesDAO();
            Cliente clientes = dao.BuscaPorConta(NuConta);
            dao.Remover(clientes);
            return Json(clientes);
        }
    }
   

}

