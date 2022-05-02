using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadoApp2
{
    internal class Juego
    {
        public double pozo = 10000;
        public int dado1Jugador, dado2Jugador, montoApostado;


        public void Conservador(Jugadores participante,
            Dados dado1,
            Dados dado2)
        {
            //Pedir las numeros a los jugadores
            Console.WriteLine("Jugador, Ingrese el lado del primer dado a cual le apuesta ");
            dado1Jugador = Convert.ToInt32(Console.ReadLine());
            dado1.setDadoApuesta(dado1Jugador);

            Console.WriteLine("Jugador, Ingrese el lado del segundo dado a cual le apuesta ");
            dado2Jugador = Convert.ToInt32(Console.ReadLine());
            dado2.setDadoApuesta(dado2Jugador);

            //Pidiendo apuestas y Comprobando saldos de jugadores
            Console.WriteLine("Jugador, ingrese el monto a apostar: ");
            montoApostado = Convert.ToInt32(Console.ReadLine());
            if (pozo < montoApostado)
            {
                Console.WriteLine("ERROR FATAL, EL POZO ES INSUFICIENTE. SE TERMINA EL JUEGO CIERRA EL CASINO");
            } else
            {
                if (participante.getSaldo() < montoApostado)
                {
                    Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("El saldo del jugador 1 es de " + participante.getSaldo() + "$");
                }
                else
                {
                    Console.WriteLine("LANZANDO DADOS......");
                    dado1.lanzar();
                    dado2.lanzar();
                    Console.WriteLine("El DADO 1 arrojo: " + dado1.getCaraActual());
                    Console.WriteLine("El DADO 2 arrojo: " + dado2.getCaraActual());

                    if ((dado1.getCaraActual() + dado2.getCaraActual()) >= (dado1Jugador + dado2Jugador))
                    {
                        //El jugador pierde
                        participante.setSaldo(participante.getSaldo() - montoApostado);
                        Console.WriteLine("El participante pierde, su saldo es: " + participante.getSaldo());
                        if (participante.getSaldo() < 0)
                        {
                            this.pozo += (montoApostado - participante.getSaldo() * -1);
                        }
                        else
                        {
                            this.pozo += montoApostado;
                        }
                    }
                    else
                    {
                        //El jugador gana
                        participante.setSaldo(participante.getSaldo() + montoApostado);
                        Console.WriteLine("El Jugador gana, su saldo es de: " + participante.getSaldo());
                        this.pozo -= montoApostado;
                    }
                    Console.WriteLine("EL POZO ACTUALMENTE ES DE: " + this.pozo + "$");
                }
            }


            

        }
        public void Arriesgado(Jugadores participante,
            Dados dado1,
            Dados dado2)
        {
            //Pedir las numeros a los jugadores
            Console.WriteLine("Jugador 1: Ingrese el lado del primer dado a cual le apuesta ");
            dado1Jugador = Convert.ToInt32(Console.ReadLine());
            dado1.setDadoApuesta(dado1Jugador);

            Console.WriteLine("Jugador 1: Ingrese el lado del segundo dado a cual le apuesta ");
            dado2Jugador = Convert.ToInt32(Console.ReadLine());
            dado2.setDadoApuesta(dado2Jugador);

            //Pidiendo apuestas y Comprobando saldos de jugadores
            Console.WriteLine("Jugador 1 ingrese el monto a apostar: ");
            montoApostado = Convert.ToInt32(Console.ReadLine());

            if (pozo < montoApostado)
            {
                Console.WriteLine("ERROR FATAL, EL POZO ES INSUFICIENTE. SE TERMINA EL JUEGO CIERRA EL CASINO");
            } else
            {
                if (participante.getSaldo() < montoApostado)
                {
                    Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("El saldo del jugador 1 es de " + participante.getSaldo() + "$");
                }
                else
                {
                    Console.WriteLine("LANZANDO DADOS......");
                    dado1.lanzar();
                    dado2.lanzar();
                    Console.WriteLine("El DADO 1 arrojo: " + dado1.getCaraActual());
                    Console.WriteLine("El DADO 2 arrojo: " + dado2.getCaraActual());

                    if ((dado1.getCaraActual() + dado2.getCaraActual()) >= (dado1Jugador + dado2Jugador))
                    {
                        //El jugador pierde
                        participante.setSaldo(participante.getSaldo() - montoApostado);
                        Console.WriteLine("El participante pierde, su saldo es: " + participante.getSaldo());
                        if (participante.getSaldo() < 0)
                        {
                            this.pozo += (montoApostado - participante.getSaldo() * -1);
                        }
                        else
                        {
                            this.pozo += montoApostado;
                        }
                    }
                    else
                    {
                        //El jugador gana
                        participante.setSaldo(participante.getSaldo() + montoApostado * 2.5);
                        Console.WriteLine("El Jugador gana, su saldo es de: " + participante.getSaldo());
                        this.pozo -= montoApostado * 2.5;
                    }
                    Console.WriteLine("EL POZO ACTUALMENTE ES DE: " + this.pozo + "$");
                }
            }


            

        }

        public void Desesperado(Jugadores participante,
            Dados dado1,
            Dados dado2)
        {
            //Pedir las numeros a los jugadores
            Console.WriteLine("Jugador 1: Ingrese el lado del primer dado a cual le apuesta ");
            dado1Jugador = Convert.ToInt32(Console.ReadLine());
            dado1.setDadoApuesta(dado1Jugador);

            Console.WriteLine("Jugador 1: Ingrese el lado del segundo dado a cual le apuesta ");
            dado2Jugador = Convert.ToInt32(Console.ReadLine());
            dado2.setDadoApuesta(dado2Jugador);

            //Pidiendo apuestas y Comprobando saldos de jugadores
            Console.WriteLine("Jugador 1 ingrese el monto a apostar: ");
            montoApostado = Convert.ToInt32(Console.ReadLine());

            if (pozo < montoApostado)
            {
                Console.WriteLine("ERROR FATAL, EL POZO ES INSUFICIENTE. SE TERMINA EL JUEGO CIERRA EL CASINO");
            }
            else
            {
                if (participante.getSaldo() < montoApostado)
                {
                    Console.WriteLine("Saldo insuficiente");
                    Console.WriteLine("El saldo del jugador 1 es de " + participante.getSaldo() + "$");
                }
                else
                {
                    Console.WriteLine("LANZANDO DADOS......");
                    dado1.lanzar();
                    dado2.lanzar();
                    Console.WriteLine("El DADO 1 arrojo: " + dado1.getCaraActual());
                    Console.WriteLine("El DADO 2 arrojo: " + dado2.getCaraActual());

                    if ((dado1.getCaraActual() + dado2.getCaraActual()) >= (dado1Jugador + dado2Jugador))
                    {
                        //El jugador pierde
                        participante.setSaldo(participante.getSaldo() - montoApostado);
                        Console.WriteLine("El participante pierde, su saldo es: " + participante.getSaldo());
                        if (participante.getSaldo() < 0)
                        {
                            this.pozo += (montoApostado - participante.getSaldo() * -1);
                        }
                        else
                        {
                            this.pozo += montoApostado;
                        }
                    }
                    else
                    {
                        //El jugador gana
                        participante.setSaldo(participante.getSaldo() + montoApostado * 3.75);
                        Console.WriteLine("El Jugador gana, su saldo es de: " + participante.getSaldo());
                        this.pozo -= montoApostado * 3.75;
                    }
                    Console.WriteLine("EL POZO ACTUALMENTE ES DE: " + this.pozo + "$");
                }
            }
        }
    }
}
