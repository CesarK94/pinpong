using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingPong.Core;

namespace pinpong
{
    public class Tablero : IGameObject
    {
        public int Width { get; set; } = 25;
        public int Height { get; set; } = 10;
        public Pelota Pelota { get; set; }
        public Tablero(Pelota pelota)
        {
            Pelota = pelota;
        }

        public void OnDraw()
        {
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("_");
                Console.SetCursorPosition(i, Height);
                Console.Write("_");
            }
            for (int i = 1; i < Height+1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(Width, i);
                Console.Write("|");
            }
        }
    }
}
