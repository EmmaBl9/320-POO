using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class aleaValueHelpers
    {
        public static Random Random = new Random();
        public static int AleaValue()
        {
            return Random.Next(-2, 3);
        }
        public static int AleaPosition()
        {
            return Random.Next(0, 500);
        }

    }
}
