using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public static class Config
    {

        public const int WIDTH = 1200;        // Dimensions of the airspace
        public const int HEIGHT = 600;

        //Dimensions (Largeur, Profondeur (parce qu'on regarde depuis en haut! On ne peut pas représenter la hauteur du bâtiment))
        public const int BUILDINGWIDTH = 50;
        public const int BUILDINGHEIGHT = 50;

    }
}
