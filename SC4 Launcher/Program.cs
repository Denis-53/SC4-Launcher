using System.Diagnostics;
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
            Console.WriteLine(Prog_data.version.ToString());
            var buildTime = prog.GetLinkerTime(Assembly.GetEntryAssembly());
            Console.WriteLine($"Build time at {buildTime}");

            foreach (string arg in args)
            {
                if(arg == "-hidden")
                {
                    Prog_data.hidden_mode = true;
                    Debug.WriteLine("HIDDEN");
                    Debug.WriteLine($"hidden_mode: {Prog_data.hidden_mode}");
                }
                else if (arg.Contains("-p"))
                {
                    int profile_index = 0;
                    Int32.TryParse(arg.Substring(arg.IndexOf("-p")+2), out profile_index);
                    Prog_data.profile = profile_index;
                }
                else if (arg.Contains("-autoclose"))
                {
                    Prog_data.autoclose = true;
                }
                else if (arg.Contains("-autores"))
                {
                    Prog_data.autores = true;
                }

            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

}
