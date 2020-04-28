using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DAO
{
    public class TransacoesDAO
    {
        public object RegistroDeSaque { get; private set; }

        public void CreditarSaldo(Transacoes transacoes)
            {
                using (var context = new EstoqueContext())
                {

                    context.Transacoes.Add(transacoes);
                    context.SaveChanges();
                }
            }
            public IList<Transacoes> Lista()
            {
                using (var contexto = new EstoqueContext())
                {
                    return contexto.Transacoes.Include("NumeroConta").ToList();
                }
            }
            public void AtualizaSaldo(Transacoes transacoes)
            {
                using (var contexto = new EstoqueContext())
                {
                    contexto.Entry(transacoes).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                }
            }
            public Transacoes BuscaPorNuConta(int Nuconta)
            {
                using (var contexto = new EstoqueContext())
                {
                    return contexto.Transacoes.Include("NuConta")
                        .Where(p => p.NuConta == Nuconta)
                        .FirstOrDefault();
                }
            }
        public void RegistrarSaque(Transacoes transacoes)
        {
            using (var context = new EstoqueContext())
            {
               
                context.Transacoes.Add(transacoes);
                context.SaveChanges();
            }
        }
    }
    }
