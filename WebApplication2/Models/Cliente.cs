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

        [StringLength(50, ErrorMessage = "O campo Nome permite no máximo 50 caracteres!")]
        public string Nome { get; set; }

        public string Sacar(int v)
        {
            throw new NotImplementedException();
        }

        [Required(ErrorMessage = "Informe o valor de saldo")]
        public int Saldo { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }

      
    }
}
