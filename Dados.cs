using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadoApp2
{
    internal class Dados
    {

        private int caraActual;
        private int dadoApuesta;

        public Dados()
        {
            caraActual = 1;
        }

        public void setDadoApuesta(int dadoApuesta)
        {
            if(dadoApuesta < 7 && dadoApuesta > 0)
            {
                this.dadoApuesta = dadoApuesta;
            } else
            {
                Console.WriteLine("Error, valor incorrecto");
            }
        }

        public int getDadoApuesta()
        {
            return dadoApuesta;
        }

        public void setCaraActual(int caraActual)
        {
            this.caraActual = caraActual;
        }

        public int getCaraActual()
        {
            return caraActual;
        }


        public void lanzar()
        {
            Random rndm = new Random(); 
            int numero = rndm.Next(1, 7);
            this.caraActual = numero;
        }
    }
}
