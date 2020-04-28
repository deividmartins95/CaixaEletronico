using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.DAO
{
    public class UsuariosDAO
    {
        public IList<Usuario> Lista()
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Usuarios.ToList();
            }
        }

        public Usuario BuscaPorConta(int Nuconta)
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Usuarios.Find(Nuconta);
            }
        }
        public void Cadastrar(Usuario usuario)
        {
            using (var context = new EstoqueContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }
        public Usuario Busca(int login, string senha)
        {
            using (var contexto = new EstoqueContext())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.NuConta == login && u.Senha == senha);
            }
        }
    }
}
