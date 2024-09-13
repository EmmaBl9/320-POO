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
    }
}
