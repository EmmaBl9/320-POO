using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Building
    {
        //Emplacement (coordonnées x,y) avec encapsulation
        private int _x;
        private int _y;
        private int _height;
        private int _width;
        private Color _color;

        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }

        public Color Color
        {
            get => _color;
            set
            {
                _color = value;
                _buildingBrush = new Pen(new SolidBrush(Color), 3);
            }
        }


        //Constructeur du building
        public Building(int x, int y, int height, int width)
        {
            _x = x;
            _y = y;
            _height = height;
            _width = width;
        }

        public void Update(int interval)
        {
            _y += aleaValueHelpers.AleaValue();         // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
        }

        // Couleur
        private Pen _buildingBrush;

        // Afichage graphique
        public void Render(BufferedGraphics drawingBuilding, bool isStore)
        {
            if (isStore)
            {
                drawingBuilding.Graphics.DrawEllipse(_buildingBrush, new Rectangle(_x, _y, _height, _width));
            }
            else
            {
                drawingBuilding.Graphics.DrawRectangle(_buildingBrush, new Rectangle(_x, _y, _height, _width));
            }
        }

    }
}
