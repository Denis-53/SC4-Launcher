using SimpleExec;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static SimpleExec.Command;
using System.Timers;
using System.ComponentModel;
using System.Threading;
using Microsoft.VisualBasic;

namespace SC4_Launcher
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        load_profile loader = new load_profile();
        System.Timers.Timer aTimer = new System.Timers.Timer();
        bool autosave_bit;
        bool debug_bit = false;
        public Form1()
        {
            if (Properties.Settings.Default.language != "")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.language);
            }
            else
            {
                form3.Show();
                form3.Focus();
                this.WindowState = FormWindowState.Minimized;
            }
            InitializeComponent();
            if(Properties.Settings.Default.steam_path == "")
            {
                button1.Enabled = false;
            }
            loader.load();
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            switch (loader.status)
            {
                case 0:
                    if (Properties.Settings.Default.language == "de-de")
                    {
                        MessageBox.Show("Es wurde keine Profil Datei gefunden, bitte legen Sie ein neues Profil an", "Keine Profil Datei vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("No Profile File found, please create an new Profile","No Profile File existing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                    autosave();
                    backgroundWorker2.RunWorkerAsync();
                    break;

            }
        }
        private void autosave()
        {
            int i = 0;
            while (comboBox1.Text != loader.name[i]) { i++; }
            if (loader.autosave[i] == true)
            {
                label2.Visible = true;
                label2.ForeColor = Color.Lime;
                label2.Text = "Autosave[ON]";
                autosave_bit = true;
                Debug.WriteLine("autosave");
                aTimer.Interval = 1000* 60* loader.saveintrvl[i];
            }
            else { label2.Visible = false;
                autosave_bit = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
                autosave();
                string steam_path = Properties.Settings.Default.steam_path;
                int steam_id = Properties.Settings.Default.steam_id;
                int i = 0;
                while (comboBox1.Text != loader.name[i]) { i++; }
                string arguments = "-applaunch "+steam_id;
                if (loader.custom_res[i] == true) { arguments += " -CustomResolution:enabled -r" + loader.width[i] + "x" + loader.height[i] + "x" + loader.depth[i]; }
                if (loader.rendering[i] == true) { arguments += " -d:" + loader.rendering_mode[i]; }
                if (loader.window_mode[i] == true) { arguments += " -w"; }
                else { arguments += " -f"; }
                if (loader.cpu_cores[i] != "default") { arguments += " -CPUCount:" + loader.cpu_cores[i]; }
                if (loader.cpu_priority[i] != "default") { arguments += " -CPUPriority:" + loader.cpu_priority[i];}
                if (loader.sound_off[i] == true) { arguments += " -audio:off"; }
                else { arguments += " -audio:on"; }
                if (loader.intro_off[i] == true) { arguments += " -Intro:off"; }
                string autosave_txt;
                if (autosave_bit) { autosave_txt = "Autosave: ON"; } else { autosave_txt = "Autosave: OFF"; }
                if (debug_bit) { MessageBox.Show(steam_path+"\n"+arguments+"\n"+autosave_txt, "debug"); }
                Run(steam_path ,arguments);
                backgroundWorker1.RunWorkerAsync();


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
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Debug.WriteLine("TEST");
            SendKeys.SendWait("^s");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool running = false;
            bool started = false;
            bool end = false;

            while (autosave_bit == true && end == false)
            {
                Process[] processlist = Process.GetProcessesByName("SimCity 4");
                foreach (Process theprocess in processlist)
                {
                    Debug.WriteLine("Laueft");

                    running = true;
                }
                if (started == false && running == true) { started = true; aTimer.Enabled = true; backgroundWorker1.ReportProgress(1); }
                if (running == false && started == true)
                {
                    Debug.WriteLine("Laueft nicht mehr");
                    end = true;
                }
                running = false;
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label2.Text += " Game Running";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label2.ForeColor = Color.Yellow;
            label2.Text = "Game stopped";
            aTimer.Enabled = false;
        }

        private void comboBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            autosave();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("steam");
            if (pname.Length == 0)
            {
                Run(Properties.Settings.Default.steam_path, "-silent");
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if(debug_bit == false)
            {
                label3.Visible = true;
                debug_bit= true;
            }
            else
            {
                label3.Visible = false;
                debug_bit = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}