using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAO;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Autentica(int login, String senha)
        {

            ClientesDAO dao = new ClientesDAO();
            Cliente Clientes = dao.Busca(login, senha);
            if (Clientes == null)
            {
                ModelState.AddModelError("", "Usuário ou senha inválidos");
            }
            if (senha == null)
            {
                ModelState.AddModelError("", "Usuário ou senha inválidos");
            }
            if (Clientes != null)
            {
                //Session["usuarioLogado"] = usuario;
                Session["nome"] = Clientes.Nome;
                Session["nuconta"] = Clientes.NuConta;
                return RedirectToAction("Index", "Operacoes");
                


            }
            else
            {
                ModelState.AddModelError("", "Usuário ou senha inválidos");
                return RedirectToAction("Index", "Login");
            }

          
        }
    }
}