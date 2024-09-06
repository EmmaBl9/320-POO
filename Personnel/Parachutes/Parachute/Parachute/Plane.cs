using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Plane
    {
        // dimensions of the ASCII representation of the plane
        public const int WIDTH = 28;
        public const int HEIGHT = 6;

        private string[] view =
{
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        // Model attributes
        private int _x;
        public int altitude;
        public List<Para> parachutists;

        public int X { get => _x; set => _x = value; }

        public Plane()
        {
            _x = 0;
            altitude = Config.SCREEN_HEIGHT;
            parachutists = new List<Para>();
        }

        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x, i);
                Console.Write(view[i]);
            }
        }

        public void update()
        {
            if (_x >= Config.SCREEN_WIDTH)
            {
                _x = 0;
            }
            else
            {
                _x++;
            }
        }

        public void board(Para para)
        {
            this.parachutists.Add(para);
        }

        internal Para dropParachutist()
        {
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist.X = _x;
            parachutist.Altitude = this.altitude;
            return parachutist;
        }

    }
}
