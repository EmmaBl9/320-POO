using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Box
    {
        private int id;
        private int nombreMaxSmarties = 10;
        private int nombreMinSmarties = 5;
        private Color colorSmarties;

        // Créer une instance random
        public static Random Random = new Random();

        public enum Color
        {
            RED, 
            BLUE,
            ORANGE,
            YELLOW,
            BROWN
        }

    }
}
