namespace SC4_Launcher
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                if(arg == "-hidden")
                {

                }
                else if (arg.Contains("-p"))
                {

                }
                else if (arg.Contains("-autores"))
                {

                }

            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

}
