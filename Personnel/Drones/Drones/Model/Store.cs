using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Store : Building
    {
        private decimal _openingHours;                //Consomation d'énergie

        public decimal OpeningHours { get { return _openingHours; } set { _openingHours = value; } }

    }
}
