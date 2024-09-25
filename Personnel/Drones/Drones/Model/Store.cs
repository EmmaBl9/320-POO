using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        private decimal _openingHours;                //Consomation d'énergie

        public Store(int x, int y, int height, int width) : base(x, y, height, width)
        {
        }

        public decimal OpeningHours { get { return _openingHours; } set { _openingHours = value; } }

    }
}
