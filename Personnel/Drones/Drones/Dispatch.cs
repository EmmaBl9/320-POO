using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Dispatch : Building
    {
        // Instancier la central de production
        public Dispatch(int x, int y, int height, int width) : base(x, y, height, width)
        {

        }
    }
}
