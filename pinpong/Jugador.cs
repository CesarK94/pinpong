using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpong
{
    public class Jugador
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; } = 0;
        public object? Source { get; set; }

        public Jugador()
        {
            
        }
    }
}
