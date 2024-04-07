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
            bool hidden_mode = false;
            int profile = 0;
            bool autores = false;

            foreach (string arg in args)
            {
                if(arg == "-hidden")
                {
                    hidden_mode = true;
                }
                else if (arg.Contains("-p"))
                {
                    Int32.TryParse(arg.Substring(arg.IndexOf("-p")+2), out profile);
                }
                else if (arg.Contains("-autores"))
                {
                    autores = true;
                }

            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(hidden_mode, profile, autores));
        }
    }

}
