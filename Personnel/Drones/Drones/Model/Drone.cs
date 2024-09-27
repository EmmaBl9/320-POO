
using System.Security.Policy;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        Random alea = new Random();

        private int _charge = 1000;                     // La _charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x;                                 // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private bool _lowBattery;                       // Batterie faible
        private Rectangle _NoFlightzone;
        private Rectangle _zoneDrone;                   // Zone du drone
        private EvacuationState _evacuationState;       // Evacuation du rectangle

        public int Charge { get { return _charge; } set { _charge = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }
        public bool LowBattery { get { return _lowBattery; } }

        public Drone(int x, int y)
        {
            _x = x;
            _y = y;
            _evacuationState = EvacuationState.Free;
        }

        public bool Evacuate(Rectangle zone)
        {
            _zoneDrone = new Rectangle(_x - 4, _y - 2, 8, 8);

            _NoFlightzone = zone;

            if (!zone.IntersectsWith(_zoneDrone))
            {
                _evacuationState = EvacuationState.Evacuated;
                return true;
            }
            else
            {
                _evacuationState = EvacuationState.Evacuating;
                return false;
            }

        }

        public void FreeFlight()
        {
            _NoFlightzone = Rectangle.Empty;
            _evacuationState = EvacuationState.Free;
        }

        public EvacuationState GetEvacuationState()
        {

            return _evacuationState;
        }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            _x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            _y += aleaValueHelpers.AleaValue();         // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            _charge--;                                  // Il a dépensé de l'énergie

            //Condition : la methode _lowbattery est vraie quand la charge est en dessous de 20%
            if (_charge < (_charge * 20 / 100))
            {
                _lowBattery = true;
            }
            else
            {
                _lowBattery = false;
            }
        }




    }
}
