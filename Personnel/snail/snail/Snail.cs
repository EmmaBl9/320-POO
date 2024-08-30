using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace snail
{
    internal class Snail
    {
        // Attributs
        public int pifle = 50;                  // Point de vie
        public int X = 0;                       // Position
        public int y = 0;                       // Position
        public String alive = "_@_ö";           // Escargot en vie
        public String dead = "____";            // Escargot mort
        public String name = "";

        // Constructeur 
        public Snail(int y)
        {
            this.y = y;
            this.name = "Escargot" + y;
        }

        // Méthode
        public void Move()
        {
            X++;
            pifle--;
        }


    }
}
