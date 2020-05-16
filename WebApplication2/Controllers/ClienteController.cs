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

        

        public ActionResult Form()
        {
            return View();
        }

       

      
       
      
        public ActionResult VisualizaCliente(int NuConta)
        {
            ClientesDAO dao = new ClientesDAO();
            Cliente clientes = dao.BuscaPorConta(NuConta);
            ViewBag.Cliente = clientes;
            return View();
        }
       
    }
   

}

