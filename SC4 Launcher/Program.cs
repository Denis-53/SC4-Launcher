using System.Reflection;
using System.Runtime.InteropServices;
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
            Prog_data prog = new Prog_data();
            Console.WriteLine(prog.version.ToString());
            var buildTime = prog.GetLinkerTime(Assembly.GetEntryAssembly());
            Console.WriteLine($"Build time at {buildTime}");

            foreach (string arg in args)
            {
                if(arg == "-hidden")
                {
                    prog.hidden_mode = true;
                }
                else if (arg.Contains("-p"))
                {
                    Int32.TryParse(arg.Substring(arg.IndexOf("-p")+2), out prog.profile);
                }
                else if (arg.Contains("-autores"))
                {
                    prog.autores = true;
                }

            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

}
