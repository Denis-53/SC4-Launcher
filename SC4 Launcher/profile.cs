using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SC4_Launcher
{
    public class buffer
    {
        public static List<int> index = new List<int>();
        public static List<string> name = new List<string>();
        public static List<bool> custom_res = new List<bool>();
        public static List<int> height = new List<int>();
        public static List<int> width = new List<int>();
        public static List<int> depth = new List<int>();
        public static List<bool> rendering = new List<bool>();
        public static List<string> rendering_mode = new List<string>();
        public static List<bool> window_mode = new List<bool>();

        public static List<string> cpu_cores = new List<string>();
        public static List<string> cpu_priority = new List<string>();

        public static List<bool> sound_off = new List<bool>();
        public static List<bool> intro_off = new List<bool>();
    }
    public class write_profile
    {
        public int index;
        public string name;
        public bool custom_res;
        public int height;
        public int width;
        public int depth;
        public bool rendering;
        public string rendering_mode;
        public bool window_mode;

        public string cpu_cores;
        public string cpu_priority;

        public bool sound_off;
        public bool intro_off;

        //JSON Serialized
        public void write()
        {
            string output="";
            string userdata;
            string fileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/profile.json";
            List<string> JSONs = new List<string>();
            write_profile user = new write_profile();

            for (int i = 0; i < buffer.index.Count; i++)
            {
                Debug.WriteLine(i, "COUNT");
                user.index = buffer.index[i];
                user.name = buffer.name[i];
                user.custom_res = buffer.custom_res[i];
                user.height = buffer.height[i];
                user.width = buffer.width[i];
                user.depth = buffer.depth[i];
                user.rendering = buffer.rendering[i];
                user.rendering_mode = buffer.rendering_mode[i];
                user.window_mode = buffer.window_mode[i];

                user.cpu_cores = buffer.cpu_cores[i];
                user.cpu_priority = buffer.cpu_priority[i];

                user.sound_off = buffer.sound_off[i];
                user.intro_off = buffer.intro_off[i];

                userdata =  JsonConvert.SerializeObject(user, Formatting.Indented);
                JSONs.Add(userdata);
            }
            if(JSONs.Count > 0)
            {
                int j = 1;
                for(int i = 0; i < JSONs.Count; i++)
                {
                    output= output + JSONs[i];
                    if(j < JSONs.Count)
                    {
                        output = output + ",";
                    }
                    j++;
                }
            }
            output = "[" + output + "]";
            
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(output);
                }
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }

            Properties.Settings.Default.Save();
        }
    }
    public class load_profile
    {
        public int status;
        public int lenght; //Lenght of JSON
        public List<int> index = new List<int>();
        public List<string> name = new List<string>();
        public List<bool> custom_res = new List<bool>();
        public List<int> height = new List<int>();
        public List<int> width = new List<int>();
        public List<int> depth = new List<int>();
        public List<bool> rendering = new List<bool>();
        public List<string> rendering_mode = new List<string>();
        public List<bool> window_mode = new List<bool>();

        public List<string> cpu_cores = new List<string>();
        public List<string> cpu_priority = new List<string>();
        public List<bool> sound_off = new List<bool>();
        public List<bool> intro_off = new List<bool>();
        public void load()
        {
            var definition = new[] { new { index = "", name = "", custom_res = "", height = "", width = "", depth = "", rendering = "", rendering_mode = "", window_mode = "", cpu_cores = "", cpu_priority = "", sound_off = "", intro_off = "" } };
            try
            {
                string file = File.ReadAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\profile.json");
                var data = JsonConvert.DeserializeAnonymousType(file, definition);
                lenght = data.Length;
                if (lenght > 0)
                {
                    status = 1;
                }else
                { status = 0; }
                // Daten Abruf in List hinzufuegen
                for (int i = 0; i < lenght; i++)
                {
                    index.Add(Convert.ToInt32(data[i].index));
                    name.Add(data[i].name);
                    custom_res.Add(Convert.ToBoolean(data[i].custom_res));
                    height.Add(Convert.ToInt32(data[i].height));
                    width.Add(Convert.ToInt32(data[i].width));
                    depth.Add(Convert.ToInt32(data[i].depth));
                    rendering.Add(Convert.ToBoolean(data[i].rendering));
                    rendering_mode.Add(data[i].rendering_mode);
                    window_mode.Add(Convert.ToBoolean(data[i].window_mode));
                    
                    cpu_cores.Add(data[i].cpu_cores);
                    cpu_priority.Add(data[i].cpu_priority);

                    sound_off.Add(Convert.ToBoolean(data[i].sound_off));
                    intro_off.Add(Convert.ToBoolean(data[i].intro_off));
                }
            }
            catch
            {
                status=0;
            }

        }
    }
}

