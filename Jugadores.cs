using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadoApp2
{
    internal class Jugadores
    {
        private double saldo;

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public Jugadores()
        {
            saldo = 100;
        }

    }
}
