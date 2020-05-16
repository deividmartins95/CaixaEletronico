using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.DAO;
using WebApplication2.Models;
using System.ComponentModel.DataAnnotations;

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
            int retorno;

            cliente.NuConta = int.Parse(form.GetValue("NuConta").AttemptedValue);
            cliente.Saldo = decimal.Parse(form.GetValue("Deposito").AttemptedValue);

            Cliente clienteBanco = dao.BuscaPorConta(cliente.NuConta);

            try
            {
                if (clienteBanco.Saldo < +cliente.Saldo)
                {
                    clienteBanco.Saldo += cliente.Saldo;

                    retorno = dao.AtualizaSaldo(clienteBanco);

                    return RedirectToAction("Index", "Operacoes");
                }
                if (cliente.Saldo == 1)
                {
                    throw new Exception("!"); ;
                }
                if (cliente.Saldo == 2)
                {
                    throw new Exception("!"); ;
                }
                if (cliente.Saldo == 5)
                {
                    throw new Exception("!"); ;
                }
                if (cliente.Saldo == 25)
                {
                    throw new Exception("!"); ;
                }
                if (cliente.Saldo == 45)
                {
                    throw new Exception("!"); ;
                }
                if (cliente.Saldo == 999)
                {
                    throw new Exception("!"); ;
                }



            }
            catch(Exception )
            {

                return RedirectToAction("Form", "Cliente");
            }
           
            return RedirectToAction("Index", "Operacoes");

        }
        [HttpPost]
        public ActionResult Sacar(FormCollection form)
        {
            ClientesDAO dao = new ClientesDAO();
            Cliente cliente = new Cliente();
            var listaNotas = new List<int>() { 10, 20, 50, 100 };
            int retorno;
           


            cliente.NuConta = int.Parse(form.GetValue("NuConta").AttemptedValue);
            cliente.Saldo = decimal.Parse(form.GetValue("Saque").AttemptedValue);

            Cliente clienteBanco = dao.BuscaPorConta(cliente.NuConta);

            try
            {
                if (clienteBanco.Saldo < cliente.Saldo)
                {
                    return RedirectToAction("Index", "Operacoes");
                }

                if (clienteBanco.Saldo >= cliente.Saldo)
                {
                    clienteBanco.Saldo -= cliente.Saldo;

                    retorno = dao.AtualizaSaldo(clienteBanco);
                }

                if (cliente.Saldo == 1)
                {
                    throw new Exception("!"); ;
                }
                if (cliente.Saldo == 2)
                {
                    throw new Exception("!"); ;
                }
                if (cliente.Saldo == 5)
                {
                    throw new Exception("!"); ;
                }
                if (cliente.Saldo == 25)
                {
                    throw new Exception("!"); ;
                }
                if (cliente.Saldo == 45)
                {
                    throw new Exception("!"); ;
                }
                if (cliente.Saldo == 999)
                {
                    throw new Exception("!"); ;
                }



            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Operacoes");
            }

            return RedirectToAction("1121", "clientes");


        }
        //public void ValidarSaque(int valor)
        //{
        //    int totalDeNotas = 0;
        //    int resto = 0;
        //    var listaNotas = new List<int>() { 10, 20, 50, 100 };
          

        //    for (int i = 0;  i++)
        //    {
        //        bool existeNotas = ValidarQuantidadeNotasRetirada();

        //        if (existeNotas)
        //        {
        //            int nota = [i];

        //            if (Saldo < nota)
        //            {
                        
        //            }

        //            resto = valor % nota;
        //            totalDeNotas = valor / nota;
        //            RegistrarSaque(nota, totalDeNotas);
        //            ExibirMsg($"Qt Notas : {totalDeNotas}  |  Valor da Nota : {nota}");
        //        }
        //        else
        //        {
                    
        //        }
        //        valor = resto;
        //    }
        //}

        //public void ExibirMsg(string msg) => (msg);

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
