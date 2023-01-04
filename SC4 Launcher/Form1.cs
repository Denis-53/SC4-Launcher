using SimpleExec;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata;
using System.Windows.Forms;
using static SimpleExec.Command;

namespace SC4_Launcher
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        load_profile loader = new load_profile();
        public Form1()
        {
            InitializeComponent();
            loader.load();
            switch (loader.status)
            {
                case 0:
                    MessageBox.Show("Es wurde keine Profil Datei gefunden. Bitte legen Sie ein neues Profil an", "Keine Profil Datei vorhanden",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Enabled = false;
                    comboBox1.Enabled = false;
                    form2.Show();
                    form2.BringToFront();
                    form2.Focus();
                    break;
                case 1:
                    for (int i = 0; i < loader.lenght; i++) //Add combobox registers
                    {
                        try
                        {
                            comboBox1.Items.Add(loader.name[i]);
                        }
                        catch
                        {
                            MessageBox.Show("Fehler beim Lesen der Profil Datei", "Fehler Profil Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Close();
                        }
                    }
                    comboBox1.SelectedIndex = 0;
                    Debug.WriteLine(loader.name[0], loader.index[0]);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string steam_path = Properties.Settings.Default.steam_path;
                int steam_id = Properties.Settings.Default.steam_id;
                int i = 0;
                while (comboBox1.Text != loader.name[i]) { i++; }
                string arguments = "-applaunch "+steam_id;
                if (loader.custom_res[i] == true) { arguments +=" -CustomResolution:enabled -r" + loader.width[i] + "x" + loader.height[i] + "x" + loader.depth[i]; }
                if (loader.rendering[i] == true) { arguments += " -d:" + loader.rendering_mode[i]; }
                if (loader.window_mode[i] == true) { arguments += " -w"; }
                else { arguments += " -f"; }
                if (loader.sound_off[i] == true) { arguments += " -audio:off"; }
                else { arguments += " -audio:on"; }
                if (loader.intro_off[i] == true) { arguments += " -Intro:off"; }
                Debug.WriteLine(arguments);
                Run(steam_path ,arguments);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.Show();
            form2.Focus();
        }
        public void close()
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}