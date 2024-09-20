using Drones.Model;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet = new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            // Création d'un building
            List<Building> Buildings = new List<Building>();
            for (int i = 1; i < 8; i++)
            {
                // Position du building et taille du building
                Building building = new Building(aleaValueHelpers.AleaPosition(), aleaValueHelpers.AleaPosition(), Config.BUILDINGHEIGHT, Config.BUILDINGWIDTH);
                Buildings.Add(building);

            }

            // Création de la flotte de drones
            List<Factory> Factories = new List<Factory>();
            Factory factory = new Factory();
            factory.X = 100;
            factory.Y = 100;
            factory.Name = "Factory";
            Factories.Add(factory);

            // Démarrage
            Application.Run(new AirSpace(fleet, Buildings, Factories));
        }
    }
}