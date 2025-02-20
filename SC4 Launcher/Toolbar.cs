using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Image = System.Drawing.Image;

namespace SC4_Launcher
{
    public class Toolbar_struct
    {
        public bool visible { get; set; }
        public Image? icon { get; set; }
        public string name { get; set; }
        public string path { get; set; }

    }
    public class Toolbar_save_struct
    {
        public bool visible { get; set; }
        public string name { get; set; }
        public string path { get; set; }
    }


    public class Toolbar
    {
        private ImageList imageList = new ImageList(); // Speichert alle Icons für alle Buttons

        private string enviroment = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/SC4_Launcher/toolbar.json";
        public static BindingList<Toolbar_struct> bar_elements = new BindingList<Toolbar_struct>();

        public void generate_buttons(Color backgrnd, Panel targetPanel)
        {
            imageList.Images.Clear(); // Liste leeren, damit keine doppelten Icons entstehen
            imageList.ImageSize = new Size(20, 20);
            imageList.ColorDepth = ColorDepth.Depth32Bit; // WICHTIG: 32-Bit Farben für Transparenz

            int i = 0;
            foreach (var element in bar_elements)
            {
                Button button = new RectangleButton
                {
                    Text = element.name,
                    TextAlign = ContentAlignment.MiddleRight,
                    Width = TextRenderer.MeasureText(element.name, new System.Drawing.Font("Arial", 10)).Width,
                    Height = 20,
                    BackColor = backgrnd,
                    ForeColor = Color.White,
                    Margin = new Padding(6, 2, 0, 0),
                    Visible = element.visible
                };

                if (element.icon != null)
                {
                    Debug.WriteLine($"✔ Icon gefunden für {element.name}");
                    button.Width += 30; // Zusätzlicher Platz für das Icon
                    int imageIndex = imageList.Images.Count; // Sicherstellen, dass der Index korrekt ist
                    imageList.Images.Add(element.icon); // Icon zur globalen `ImageList` hinzufügen
                    button.ImageList = imageList; // Gleiche `ImageList` für alle Buttons
                    button.ImageIndex = imageIndex; // Richtiges Icon setzen
                }

                button.Click += (s, e) =>
                {
                    Process.Start(new ProcessStartInfo(element.path) { UseShellExecute = true }); // Datei/Programm öffnen
                };

                targetPanel.Controls.Add(button);
                i++;
            }
        }


        public Image? geticon(string filePath)
        {
            Icon? icon = Icon.ExtractAssociatedIcon(filePath);
            return icon?.ToBitmap(); // Falls kein Icon vorhanden ist, wird null zurückgegeben
        }
        public void save_toolbar()
        {
            List<Toolbar_save_struct> save = bar_elements
                .Select(item => new Toolbar_save_struct
                {
                    visible = item.visible,
                    name = item.name,
                    path = item.path
                   
                })
                .ToList();
            string json = JsonConvert.SerializeObject(save, Formatting.Indented);
            File.WriteAllText(enviroment, json); // Speichert die Daten in eine JSON-Datei
        }
        public bool check_buttons_enabled()
        {
            foreach (var item in bar_elements)
            {
                if (item.visible)
                {
                    return true;
                }
            }
            return false;
        }

        public void load_toolbar()
        {
            if (File.Exists(enviroment)) // Prüfen, ob die Datei existiert
            {
                string json = File.ReadAllText(enviroment); // JSON-Datei einlesen
                List<Toolbar_save_struct> loadedData = JsonConvert.DeserializeObject<List<Toolbar_save_struct>>(json);

                // Die vorhandene Liste leeren
                bar_elements.Clear();

                // Daten aus der geladenen Liste in `bar_elements` umwandeln
                foreach (var item in loadedData)
                {
                    bar_elements.Add(new Toolbar_struct
                    {
                        visible = item.visible,
                        name = item.name,
                        path = item.path,
                        icon = geticon(item.path) // Icon anhand des Dateipfads neu laden
                    });
                }
            }
            else
            {
                Debug.WriteLine("Keine gespeicherte Datei gefunden.");
            }

        }

    }

}
