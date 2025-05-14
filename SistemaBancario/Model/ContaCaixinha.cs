using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Model
{
    public class ContaCaixinha : Conta
    {
        public ContaCaixinha(decimal saldoInicial) : base(saldoInicial) { }

        public override void Depositar(decimal valor)
        {
            if (valor < 1)
                throw new ArgumentOutOfRangeException(nameof(valor), "Depósitos devem ser de pelo menos R$1,00.");
            base.Depositar(1); // Incrementa R$1,00 no saldo
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(5); // Decrementa R$5,00 no saldo
        }
    }
}
