namespace CafeApiProj
{
    //Created by Aron Sopra 
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDbContext AppDbContext = new AppDbContext();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu(AppDbContext));
        }
    }
}