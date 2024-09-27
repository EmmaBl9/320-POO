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

            //Drone 1
            for (int i = 1; i <= 5; i++)
            {
                Drone drone = new Drone(aleaValueHelpers.AleaPosition(), aleaValueHelpers.AleaPosition());
                drone.Name = "Joe";
                fleet.Add(drone);
            }


            // Création d'un building
            List<Building> Buildings = new List<Building>();
            for (int i = 1; i < 8; i++)
            {
                // Position du building et taille du building
                Building building = new Building(aleaValueHelpers.AleaPosition(), aleaValueHelpers.AleaPosition(), Config.BUILDINGHEIGHT, Config.BUILDINGWIDTH);
                Buildings.Add(building);

            }

            // Création de la flotte de drones
            Factory factory = new Factory(10, 10, 10, 10, Color.Purple);
            factory.X = 100;
            factory.Y = 100;
            Buildings.Add(factory);

            try
            {
                Application.Run(new AirSpace(fleet, Buildings));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}