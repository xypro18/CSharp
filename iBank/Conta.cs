using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBank
{
    public class Conta
    {
        public int Nconta;
        public string Titular;
        public double Saldo;
        public Boolean Desativa;

        public void LevDinheiro(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
            }
        }

        public void DepDinheiro(double valor)
        {
            this.Saldo += valor;
        }
    }
}
