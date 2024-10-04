using Drones;

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

            // Création d'un magasin
            for (int i = 1; i < 5; i++)
            {
                Store store = new Store(aleaValueHelpers.AleaPosition(), aleaValueHelpers.AleaPosition(), Config.BUILDINGHEIGHT, Config.BUILDINGWIDTH);
                store.Color = Color.Purple;
                Buildings.Add(store);
            }

            // Création d'une usine
            for (int i = 1; i < 5; i++)
            {
                Factory factory = new Factory(aleaValueHelpers.AleaPosition(), aleaValueHelpers.AleaPosition(), Config.BUILDINGHEIGHT, Config.BUILDINGWIDTH);
                factory.Color = Color.DeepPink;
                Buildings.Add(factory);
            }

            // Test pour le lancement
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