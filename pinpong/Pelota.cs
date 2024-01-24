using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinpong
{
    public class Pelota
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; } = 0;
        public string Source { get; set; } = "O";

        public Pelota()
        {
            
        }
    }
}
