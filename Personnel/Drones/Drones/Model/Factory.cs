using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Factory : Building
    {
        private decimal _powerConsumation;                //Consomation d'énergie
        private int _id;
        private int _cooldown;

        public Factory(int x, int y, int height, int width, int id) : base(x, y, height, width)
        {
            _id = id;
            _cooldown = aleaValueHelpers.Random.Next(50, 60);

        }

        public decimal PowerConsumation { get { return _powerConsumation; } set { _powerConsumation = value; } }

        public int Id { get => _id; set => _id = value; }

        public void Update()
        {
            if (_cooldown == 0)
            {
                Console.WriteLine("Un carton à été produit à l'usine " + Id);
                _cooldown = aleaValueHelpers.Random.Next(50, 60);
            }
            else
            {
                _cooldown--;
            }

        }

    }
}


