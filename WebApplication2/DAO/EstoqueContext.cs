using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using WebApplication2.Models;

namespace WebApplication2.DAO
{
    public class EstoqueContext : DbContext
    {

       
        
        public DbSet<Cliente> clientes { get; set; }
       

    }
}

