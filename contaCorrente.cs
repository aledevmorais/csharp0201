using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Alura0201
{
    public class contaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;

        public void depositar(double valor)
        {
            this.saldo += valor;

        }
        public bool sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool transferir(double valor, contaCorrente destino)
        {
            if (this.saldo <  valor)
            {
                return false;
            }
            else
            {
                this.sacar(valor);
                destino.depositar(valor);
                return true;

            }
        }
    }
}
