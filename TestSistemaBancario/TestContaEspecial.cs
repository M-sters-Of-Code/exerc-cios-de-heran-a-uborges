using SistemaBancario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSistemaBancario
{
    [TestClass]
    public class TestContaEspecial
    {
        [TestMethod]
        public void TestSaqueAcimaSaldo()
        {
            decimal saldoInicial = 1000;
            decimal limite = 1000;
            ContaEspecial conta = new ContaEspecial(saldoInicial, limite);
            conta.Sacar(1500);
            Assert.AreEqual(conta.Saldo, -500);
        }
    }
}
