using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAO;
using WebApplication2.Models;
using static WebApplication2.Filtros.utorizacaoFilterAttribute;

namespace WebApplication2.Controllers
{
    public class OperacoesController : Controller
    {
        [AutorizacaoFilter]

        public ActionResult Index()
        {

            ClientesDAO dao = new ClientesDAO();
            IList<Cliente> clientes = dao.Lista();
            return View(clientes);
        }

        [HttpPost]

        public ActionResult Depositar(FormCollection form)
        {
            ClientesDAO dao = new ClientesDAO();
            Cliente cliente = new Cliente();
            var listaNotas = new List<int>() { 10, 20, 50, 100 };
            int retorno;

            cliente.NuConta = int.Parse(form.GetValue("NuConta").AttemptedValue);
            cliente.Saldo = int.Parse(form.GetValue("Deposito").AttemptedValue);

            Cliente clienteBanco = dao.BuscaPorConta(cliente.NuConta);

            if (cliente.Saldo > 1000)
            {
                throw new Exception(" Valor maximo para deposito é R$ : 1000 ");
            }
            if (cliente.Saldo == 2)
            {
                throw new Exception(" Valor  para deposito nâo é permitido ");
            }
            if (cliente.Saldo == 5)
            {
                throw new Exception(" Valor  para deposito nâo é  permitido ");
            }
            if (cliente.Saldo == 15)
            {
                throw new Exception(" Valor  para deposito nâo é  permitido ");
            }
            if (cliente.Saldo == 25)
            {
                throw new Exception(" Valor  para deposito nâo é  permitido ");
            }
            if (cliente.Saldo == 95)
            {
                throw new Exception(" Valor  para deposito nâo é  permitido ");
            }
            if (cliente.Saldo == 999)
            {
                throw new Exception(" Valor  para deposito nâo é  permitido ");
            }
            if (clienteBanco.Saldo < cliente.Saldo)
            {
                clienteBanco.Saldo += cliente.Saldo;

                retorno = dao.AtualizaSaldo(clienteBanco);
            }


            return RedirectToAction("1114", "clientes");
        }
        [HttpPost]
        public ActionResult Sacar(FormCollection form)
        {
            ClientesDAO dao = new ClientesDAO();
            Cliente cliente = new Cliente();
            int retorno;


            cliente.NuConta = int.Parse(form.GetValue("NuConta").AttemptedValue);
            cliente.Saldo = int.Parse(form.GetValue("Saque").AttemptedValue);

            Cliente clienteBanco = dao.BuscaPorConta(cliente.NuConta);

            if (clienteBanco.Saldo < cliente.Saldo)
            {
                throw new Exception("Valor do saque maior que o saldo");
            }
            if (cliente.Saldo == 2)
            {
                throw new Exception(" Valor  para saque nâo é permitido ");
            }
            if (cliente.Saldo == 5)
            {
                throw new Exception(" Valor  para saque nâo é  permitido ");
            }
            if (cliente.Saldo == 15)
            {
                throw new Exception(" Valor  para saque nâo é  permitido ");
            }
            if (cliente.Saldo == 25)
            {
                throw new Exception(" Valor  para saque nâo é  permitido ");
            }
            if (cliente.Saldo == 95)
            {
                throw new Exception(" Valor  para saque nâo é  permitido ");
            }
            if (cliente.Saldo == 999)
            {
                throw new Exception(" Valor  para saque nâo é  permitido ");
            }

            if (clienteBanco.Saldo > cliente.Saldo)
            {
                clienteBanco.Saldo -= cliente.Saldo;

                retorno = dao.AtualizaSaldo(clienteBanco);
            }
            else
            {

            }
            return RedirectToAction("1114", "clientes");

                       
        }
        public ActionResult Remove(int NuConta)
        {

            ClientesDAO dao = new ClientesDAO();
            Cliente clientes = dao.BuscaPorConta(NuConta);
            dao.Remover(clientes);
            return Json(clientes);
        }
        [HttpPost]
        public ActionResult Editar(FormCollection form, string function)
        {

            Cliente clientes = new Cliente();

            clientes.NuConta = int.Parse(form.GetValue("NuConta").AttemptedValue);

            clientes.Saldo = int.Parse(form.GetValue("Saldo").AttemptedValue);

            return RedirectToAction("Index", "Operacoes");

        }

        [Route("clientes/{NuConta}", Name = "Visualiza")]
        public ActionResult VisualizaCliente(int NuConta)
        {
            ClientesDAO dao = new ClientesDAO();
            Cliente clientes = dao.BuscaPorConta(NuConta);
            ViewBag.Cliente = clientes;
            return View();
        }

    }
} 
