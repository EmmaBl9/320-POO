using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Factory : Building
    {
        private decimal _powerConsumation;                //Consomation d'énergie

        public decimal PowerConsumation { get { return _powerConsumation; } set { _powerConsumation = value; } }

    }
}


