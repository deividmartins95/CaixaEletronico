using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Cliente
    {

        [Key]
        public int NuConta { get; set; }

       
        public string Nome { get; set; }

        public string Sacar(int v)
        {
            throw new NotImplementedException();
        }

        [DisplayFormat(DataFormatString = "{0,c}")]
        public decimal Saldo { get; set; }

        
        public string Senha { get; set; }

       

    }
}
