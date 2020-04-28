using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Usuario
    {
       
        [Key]       
        public int NuConta { get; set; }

        public string Nome { get; set; }

        public int Saldo { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }
    }


}
