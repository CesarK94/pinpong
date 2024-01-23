using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpong
{
    public class Tablero
    {
        public int Width { get; set; } = 25;
        public int Height { get; set; } = 10;
        public Pelota Pelota { get; set; }
        public Tablero(Pelota pelota)
        {
            Pelota = pelota;
        }
    }
}
