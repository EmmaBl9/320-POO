using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
        //Constructeur
        public Factory(int x, int y, int height, int width, Color color) : base(x, y, height, width)
        {
        }
    }
}
