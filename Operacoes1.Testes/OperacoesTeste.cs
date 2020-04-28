using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.Models;

namespace WebApplication2.Testes
{
    [TestClass]
    public class Operacoes
    {
        [TestMethod]
        public void Retorna1_100()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(100);

            // VAI RETORNAR DESSE MESMO JETO A QUANTIDADE DE NOTAS QUE QUER
            Assert.AreEqual(" notade100: 1 ", NotasUsadas);
        }

        private string Sacar(int Saldo)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Retorna2_100()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(200);

            Assert.AreEqual(" notade100: 2 ", NotasUsadas);

        }

        [TestMethod]
        public void Retorna1_50()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(50);

            Assert.AreEqual(" notade50: 1 ", NotasUsadas);
        }

        [TestMethod]
        public void Retorna1_20()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(20);

            Assert.AreEqual(" notade20: 1 ", NotasUsadas);
        }

        [TestMethod]
        public void Retorna1_100_1_50()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(150);

            Assert.AreEqual(" notade100: 1 " + " notade50: 1 ", NotasUsadas);
        }

        [TestMethod]
        public void Retorna1_100_1_50_1_20_1_10()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(180);

            Assert.AreEqual(" notade100: 1 " + " notade50: 1 " +
                            " notade20: 1 " + " notade10: 1 ", NotasUsadas);
        }

        [TestMethod]
        public void Retorna10_100()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(1000);

            Assert.AreEqual(" notade100: 10 ", NotasUsadas);
        }

        [TestMethod]
        public void Retorna10_100_1_50()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(1050);

            Assert.AreEqual(" notade100: 10 " + " notade50: 1 ", NotasUsadas);
        }

        [TestMethod]
        public void Retorna10_100_1_50_1_20_1_10()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(1080);

            Assert.AreEqual(" notade100: 10 " + " notade50: 1 " + " notade20: 1 " + " notade10: 1 ", NotasUsadas);
        }

        [TestMethod]
        public void Retorna8_100_1_50_1_10()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(860);

            Assert.AreEqual(" notade100: 8 " + " notade50: 1 " + " notade10: 1 ", NotasUsadas);
        }

        [TestMethod]
        public void RetornaCedulaIndisponivel()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(0);

            Assert.AreEqual(" Valor inválido ", NotasUsadas);
        }

        [TestMethod]
        public void RetornaNegativo()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(-2);

            Assert.AreEqual(" Valor inválido ", NotasUsadas);
        }

        [TestMethod]
        public void RetornaSemCedula()
        {
            Cliente caixa1 = new Cliente();

            string NotasUsadas = caixa1.Sacar(133);

            Assert.AreEqual(" Cédula indisponível ", NotasUsadas);
        }

    }
}
    }
}
