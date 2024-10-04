﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Factory : Building
    {
        private decimal _powerConsumation;                //Consomation d'énergie


        public Factory(int x, int y, int height, int width) : base(x, y, height, width)
        {
        }

        public decimal PowerConsumation { get { return _powerConsumation; } set { _powerConsumation = value; } }

    }
}


