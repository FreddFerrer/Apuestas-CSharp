using System;

namespace DadoApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoApuesta, continueOption;
            bool continuar = true;

            Console.WriteLine("BIENVENIDO AL CASINO");

            Dados dado1 = new Dados();
            Dados dado2 = new Dados();
            Juego partida = new Juego();
            Jugadores jugador = new Jugadores();

            Console.WriteLine("Bienvenido jugador 1, su saldo es de " + jugador.getSaldo());
            Console.WriteLine("Abrimos una nueva partida con un pozo de " + partida.pozo + "$");


            while (continuar)
            {
                //Se pregunta cual apuesta desea realizar.
                Console.WriteLine("Indique con 1, 2 o 3 que apuesta realizará el jugador: ");
                Console.WriteLine("1) conservadora - 50% de éxito - recompensa: x2 lo apostado \n2) arriesgada - 40% de éxito - recompensa: x2.5 lo apostado");
                Console.WriteLine("3) desesperada - 25 % de éxito - recompensa: x3.75 lo apostado \n");
                tipoApuesta = Convert.ToInt32(Console.ReadLine());

                switch (tipoApuesta)
                {
                    case 1:
                        partida.Conservador(jugador, dado1, dado2);
                        break;
                    case 2:
                        partida.Arriesgado(jugador, dado1, dado2);
                        break;
                    case 3:
                        partida.Desesperado(jugador, dado1, dado2);
                        break;
                }

                //Se pregunta si desea continuar o salir.
                Console.WriteLine("¿Se realizará otra apuesta? Ingrese 1 para continuar y 2 para terminar.");
                continueOption = Convert.ToInt32(Console.ReadLine());
                if (continueOption != 1)
                {
                    continuar = false;
                }
            }
            
        }
    }
}