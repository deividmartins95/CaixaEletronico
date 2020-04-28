using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Transacoes
    {

        public string Nome { get; set; }


        [Key]
        public int NuConta { get; set; }

        public double Saldo { get; private set; }

        public virtual void Sacar (double x)
        {
            this.Saldo -= x;
        }
        public virtual void Depositar(double x)
        {
            this.Saldo += x;
        }

    }
}