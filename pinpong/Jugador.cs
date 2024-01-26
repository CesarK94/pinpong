using PingPong.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace pinpong
{
    public class Jugador
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; } = 0;
        public object? Source { get; set; }
        public ICommando MoveUp { get; set; }
        public ICommando MoveDown { get; set; }

        public Jugador()
        {
            MoveDown = new GameCommand(Down, CanMove);
            MoveUp = new GameCommand(Up, CanMove);
        }

        private bool CanMove(object down)
        {
            return true;
        }
        private void Up(object move)
        {
            Console.Write("");
        }
        private void Down(object move)
        {
            Console.Write("");
        }

        public void OnDraw()
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(Source);
        }
    }
}
