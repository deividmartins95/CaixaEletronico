using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DAO
{
    public class ClientesDAO
    {
        public object RegistroDeSaque { get; private set; }

        public Cliente BuscaPorConta(int Nuconta)
            {
                using (var contexto = new EstoqueContext())
                {
                    return contexto.clientes.Find(Nuconta);
                }
            }
        public IList<Cliente> Lista()
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.clientes.ToList();
            }
        }
        public Cliente Busca(int login, string senha)
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.clientes.FirstOrDefault(u => u.NuConta == login && u.Senha == senha);
            }
        }

        public void CreditarSaldo(Cliente Clientes)
        {
            using (var context = new EstoqueContext())
            {

                context.clientes.Add(Clientes);
                context.SaveChanges();
            }

        }
        public int AtualizaSaldo(Cliente cliente)
        {
            int retorno ;
            using (var contexto = new EstoqueContext())
            {
                contexto.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                retorno = contexto.SaveChanges();
              
               
            }
               return retorno;
        }
      
        public Cliente BuscaPorNuConta(int Nuconta)
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.clientes.Include("NuConta")
                    .Where(p => p.NuConta == Nuconta)
                    .FirstOrDefault();
            }
        }
     

        public void Atualiza(Cliente Clientes)
        {
            using (var contexto = new EstoqueContext())
            {
                contexto.Entry(Clientes).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        //public void RegistrarSaque(int valorDaNota, int quantidaDeNotas)
        //{
        //    using (var context = new EstoqueContext())
        //    {

        //        context.clientes.Add( Cliente);
        //        context.SaveChanges();
        //    }

        }
       
    }


