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
using System.Drawing;
using Gma.System.MouseKeyHook;

namespace SC4_Launcher
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        load_profile loader = new load_profile();
        System.Timers.Timer aTimer = new System.Timers.Timer();
        Button mapper_bt = new Button();
        private IKeyboardMouseEvents m_GlobalHook;
        bool autosave_bit;
        bool debug_bit = false;
        bool maximied = false;
        bool alt_keys = false;
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
            if(Properties.Settings.Default.sc4_mapper_on == true)
            {
                mapper_bt.Text = "SC4 Mapper";
                mapper_bt.Location = new Point(10, this.Height-5);
                mapper_bt.Size = new Size(100, 23);
                mapper_bt.Visible= false;
                this.Controls.Add(mapper_bt);
                mapper_bt.Click += new EventHandler(mapper_bt_cl);
            }
            InitializeComponent();
            pictureBox2.Image = Properties.Resources.Triangle;
            if(Properties.Settings.Default.sc4_mapper_on == false)
            {
                pictureBox2.Visible = false;
            }
            SetPictureBoxAngle(pictureBox2, 180);
            
            if (Properties.Settings.Default.steam_path == "")
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
                if (loader.alt_keys[i]) { alt_keys = true; } else { alt_keys = false;}
                Debug.WriteLine(loader.alt_keys[i]);
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
            if (alt_keys == true)
            {
                Subscribe(Hook.GlobalEvents());
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label2.ForeColor = Color.Yellow;
            label2.Text = "Game stopped";
            aTimer.Enabled = false;
            if (alt_keys == true)
            {
                Unsubscribe(Hook.GlobalEvents());
            }
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



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (maximied == false)
            {
                this.Size = new Size(this.Width, this.Height + 25);
                pictureBox2.Image = Properties.Resources.Triangle;
                mapper_bt.Visible = true;
                maximied= true;
            }
            else
            {
                this.Size = new Size(this.Width, this.Height - 25);
                SetPictureBoxAngle(pictureBox2, 180);
                mapper_bt.Visible = false;
                maximied= false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void SetPictureBoxAngle(PictureBox pictureBox, float angle)
        {
            Bitmap originalImage = (Bitmap)pictureBox.Image;
            Bitmap rotatedImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics graphics = Graphics.FromImage(rotatedImage))
            {
                graphics.Clear(Color.Transparent);
                graphics.TranslateTransform((float)originalImage.Width / 2, (float)originalImage.Height / 2);
                graphics.RotateTransform(angle);
                graphics.TranslateTransform(-(float)originalImage.Width / 2, -(float)originalImage.Height / 2);
                graphics.DrawImage(originalImage, new Point(0, 0));
            }

            pictureBox.Image = rotatedImage;
        }
        private void mapper_bt_cl(object sender, EventArgs e)
        {
            Run(Properties.Settings.Default.sc4_mapper_path);
        }
        //Hook Keypress
        public void Subscribe(IKeyboardMouseEvents events)
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.KeyPress += GlobalHookKeyPress;
        }
        public void Unsubscribe(IKeyboardMouseEvents events)
        {
            m_GlobalHook.KeyPress -= GlobalHookKeyPress;

            //It is recommened to dispose it
            m_GlobalHook.Dispose();
        }
        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {

                if(e.KeyChar.Equals(Properties.Settings.Default.alt_key_end))
                {
                    SendKeys.Send("{END}");
                }
                if(e.KeyChar.Equals(Properties.Settings.Default.alt_key_pos1))
                    SendKeys.Send("{HOME}");
                }
        }

    }
