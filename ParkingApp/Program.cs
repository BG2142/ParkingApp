namespace ParkingApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // MVC pattern
            // ParserView is split into two partial Classes and files because of VS Windows form designer.

            Model model = new Model();
            Controller controller = new Controller(model);

            Form view = new MainParkingForm(controller);
            // Application.Run(view);


            Application.Run(view);
        }
    }
}