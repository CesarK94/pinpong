using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpong
{
    public class Game
    {
        private Tablero tablero;
        private Pelota pelota;
        private Jugador jugadorA;
        private Jugador jugadorB;

        public Game()
        {
            jugadorA = new Jugador();
            jugadorB = new Jugador();
            pelota = new Pelota();
            tablero = new Tablero(pelota);
            pelota.Source = "*";
            jugadorA.Source = "|";
            jugadorB.Source = "|";
            jugadorA.PositionX = 0;
            jugadorA.PositionY = tablero.Height / 2;
            jugadorB.PositionX = tablero.Width;
            jugadorB.PositionY = tablero.Height / 2;
        }

        public void OnPlay()
        {
            int velocidadx = 1;
            int velocidady = 1;

            while (true)
            {
                # region Dibujar Jugadores
                Console.SetCursorPosition(jugadorA.PositionX, jugadorA.PositionY);
                Console.Write(jugadorA.Source);

                Console.SetCursorPosition(jugadorB.PositionX, jugadorB.PositionY);
                Console.Write(jugadorB.Source);
                #endregion

                #region Dibujar Pelota y Mover
                Console.SetCursorPosition(pelota.PositionX, pelota.PositionY);
                Console.Write(pelota.Source);
                pelota.PositionX += velocidadx;
                pelota.PositionY += velocidady;
                if (pelota.PositionX >= tablero.Width)
                {
                    velocidadx = -1;
                }
                if (pelota.PositionX <= 0)
                {
                    velocidadx = 1;
                }
                if (pelota.PositionY >= tablero.Height)
                {
                    velocidady = -1;
                }
                if (pelota.PositionY <= 0)
                {
                    velocidady = 1;
                }

                Thread.Sleep(100);
                Console.Clear();
                #endregion

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.W)
                    {
                        if (jugadorA.PositionY > 0)
                        {
                            jugadorA.PositionY--;
                        } else
                        {
                            jugadorA.PositionY = 0;
                        }

                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        if (jugadorA.PositionY < tablero.Height)
                        {
                            jugadorA.PositionY++;
                        }
                        else
                        {
                            jugadorA.PositionY = tablero.Height;
                        }
                    }

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        jugadorB.PositionY--;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        jugadorB.PositionY++;
                    }

                    if (jugadorB.PositionY < 0)
                        jugadorB.PositionY = 0;
                    if (jugadorB.PositionY > tablero.Height)
                        jugadorB.PositionY = tablero.Height;
                }

            }
        }

        public void OnPause() { 
        
        }


    }

   
}
