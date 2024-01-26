using PingPong.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpong
{
    public class Game
    {
        private IGameObject tablero;
        private Pelota pelota;
        private Jugador jugadorA;
        private Jugador jugadorB;

        #region Singleton
        private static Game? _instance;
        public static Game Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Game();
                }
                return _instance;
            }
            private set { }
        }
        #endregion

        private Game()
        {
            jugadorA = new Jugador();
            jugadorB = new Jugador();
            pelota = new Pelota();
            tablero = new Tablero(pelota);
            pelota.Source = "O";
            jugadorA.Source = "(";
            jugadorB.Source = ")";
            jugadorA.PositionX = 0;
            jugadorA.PositionY = ((Tablero)tablero).Height / 2;
            jugadorB.PositionX = ((Tablero)tablero).Width;
            jugadorB.PositionY = ((Tablero)tablero).Height / 2;
            Console.CursorVisible = false;
        }

        public void OnPlay()
        {
            int velocidadx = 1;
            int velocidady = 1;

            while (true)
            {
                tablero.OnDraw();

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
                if (pelota.PositionX >= ((Tablero)tablero).Width -1 )
                {
                    velocidadx = -1;
                }
                if (pelota.PositionX <= 1)
                {
                    velocidadx = 1;
                }
                if (pelota.PositionY >= ((Tablero)tablero).Height)
                {
                    velocidady = -1;
                }
                if (pelota.PositionY <= 1)
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
                        if (jugadorA.PositionY < ((Tablero)tablero).Height)
                        {
                            jugadorA.PositionY++;
                        }
                        else
                        {
                            jugadorA.PositionY = ((Tablero)tablero).Height;
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
                    if (jugadorB.PositionY > ((Tablero)tablero).Height)
                        jugadorB.PositionY = ((Tablero)tablero).Height;
                }

            }
        }

        public void OnPause() { 
        
        }


    }

   
}
