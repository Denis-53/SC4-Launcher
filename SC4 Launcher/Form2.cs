using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SC4_Launcher
{
    public partial class Form2 : Form
    {

        int index = -1;
        bool init = false;
        OpenFileDialog ofd = new OpenFileDialog();
        write_profile writer = new write_profile();
        load_profile loader = new load_profile();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Prog_data prog = new Prog_data();
        string lang = Properties.Settings.Default.language;
        public Form2()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            ofd.Filter = "Steam | steam.exe";
            ofd.Title = "Steam Pfad";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Steam";
            InitializeComponent();
            depth_txt.Items.Add("16");
            depth_txt.Items.Add("32");
            var buildTime = prog.GetLinkerTime(Assembly.GetEntryAssembly());
            label11.Text = "Version " + Prog_data.version;
            label12.Text = $"Build time at {buildTime}";
            switch (lang)
            {
                case "de-de":
                    cpu_priority.Items.Add("Standard");
                    cpu_priority.Items.Add("Niedrig");
                    cpu_priority.Items.Add("Normal");
                    cpu_priority.Items.Add("Hoch");
                    cpu_cores.Items.Add("Standard");
                    break;
                default:
                    cpu_priority.Items.Add("default");
                    cpu_priority.Items.Add("low");
                    cpu_priority.Items.Add("normal");
                    cpu_priority.Items.Add("high");
                    cpu_cores.Items.Add("default");
                    break;
            }
            cpu_priority.SelectedIndex = 0;

            int coreCount = 0;
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            for (int i = 1; i < coreCount + 1; i++)
            {
                cpu_cores.Items.Add(i);
            }
            cpu_cores.SelectedIndex = 0;
            directxradio.Checked = true;
            textBox1.Text = Properties.Settings.Default.steam_path;
            textBox2.Text = Properties.Settings.Default.steam_id.ToString();
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            if (textBox2.Text == "0")
            {
                textBox2.Text = "24780";
            }
            loader.load();
            //Debug.WriteLine(loader.status);
            if (loader.status == 1)
            {
                for (int i = 0; i < loader.lenght; i++)
                {
                    index = loader.index[i];
                    comboBox1.Items.Add(loader.name[i]);

                    //Schreibe Daten in Buffer
                    buffer.index.Add(loader.index[i]);
                    buffer.name.Add(loader.name[i]);
                    buffer.custom_res.Add(loader.custom_res[i]);
                    buffer.height.Add(loader.height[i]);
                    buffer.width.Add(loader.width[i]);
                    buffer.depth.Add(loader.depth[i]);
                    buffer.rendering.Add(loader.rendering[i]);
                    buffer.rendering_mode.Add(loader.rendering_mode[i]);
                    buffer.window_mode.Add(loader.window_mode[i]);
                    buffer.cpu_cores.Add(loader.cpu_cores[i]);
                    buffer.cpu_priority.Add(loader.cpu_priority[i]);
                    buffer.sound_off.Add(loader.sound_off[i]);
                    buffer.intro_off.Add(loader.intro_off[i]);
                    buffer.autosave.Add(loader.autosave[i]);
                    buffer.saveintrvl.Add(loader.saveintrvl[i]);
                    buffer.alt_keys.Add(loader.alt_keys[i]);
                }
                comboBox1.SelectedIndex = 0;
                radioButton1.Checked = true;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                radioButton2.Enabled = false;
            }
            if (comboBox1.Text == "")
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
            init = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
        private void radiocheck() // Textfelder ein und ausbelenden
        {
            if (radioButton1.Checked)
            {
                profilname_txt.Enabled = true;
                comboBox1.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                comboBox1.Enabled = true;
                profilname_txt.Enabled = false;
                load_settings();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radiocheck();
        }

        private void customresbox_CheckedChanged(object sender, EventArgs e)
        {
            if (customresbox.Checked)
            {
                width_txt.Enabled = true;
                height_txt.Enabled = true;
                depth_txt.Enabled = true;
            }
            else
            {
                width_txt.Enabled = false;
                height_txt.Enabled = false;
                depth_txt.Enabled = false;
                width_txt.Text = "";
                height_txt.Text = "";
                depth_txt.SelectedIndex = -1;

            }
        }
        private void load_settings()
        {
            //Lade hier Einstellungen
            int i = loader.name.IndexOf(comboBox1.Text);
            if (loader.custom_res[i] == true)
            { //Einstellung Auflösung
                customresbox.Checked = true;
                height_txt.Text = Convert.ToString(loader.height[i]);
                width_txt.Text = Convert.ToString(loader.width[i]);
                depth_txt.SelectedItem = Convert.ToString(loader.depth[i]);
            }
            else { customresbox.Checked = false; }
            if (loader.rendering[i] == true)
            {  //Einstellung Rendering
                renderingbox.Checked = true;
                switch (loader.rendering_mode[i])
                {
                    case "DirectX":
                        directxradio.Checked = true;
                        break;
                    case "OpenGL":
                        openglradio.Checked = true;
                        break;
                    case "Software":
                        swradio.Checked = true;
                        break;
                    default:
                        renderingbox.Checked = false;
                        break;
                }
            }
            else { renderingbox.Checked = false; }
            Debug.Write(loader.window_mode[i], "WINDOWMode");
            if (loader.window_mode[i] == true) { windowmode.Checked = true; }//Fenstermodus
            else { windowmode.Checked = false; }
            if (loader.cpu_cores[i] == "default") { cpu_cores.SelectedIndex = 0; }
            else
            {
                cpu_cores.Text = loader.cpu_cores[i];
            }
            switch (loader.cpu_priority[i])
            {
                case "high":
                    cpu_priority.SelectedIndex = 3;
                    break;
                case "normal":
                    cpu_priority.SelectedIndex = 2;
                    break;
                case "low":
                    cpu_priority.SelectedIndex = 1;
                    break;
                default:
                    cpu_priority.SelectedIndex = 0;
                    break;
            }
            if (loader.sound_off[i] == true) { sound_set.Checked = true; } else { sound_set.Checked = false; }
            if (loader.intro_off[i] == true) { intro_set.Checked = true; } else { intro_set.Checked = false; }
            if (loader.autosave[i] == true) { autosave.Checked = true; } else { autosave.Checked = false; }
            if (loader.alt_keys[i] == true) { alt_keys.Checked = true; } else { alt_keys.Checked = false; }
            saveintervall.Value = loader.saveintrvl[i];
        }

        private void customresbox_MouseHover(object sender, EventArgs e)
        {
            switch (lang)
            {
                case "de-de":
                    toolTip1.SetToolTip(customresbox, "Aktivieren um benutzerdefinierte Auflösung einzustellen");
                    break;
                case "en":
                    toolTip1.SetToolTip(customresbox, "Check to define a custom resolution");
                    break;
            }
        }

        private void renderingbox_MouseHover(object sender, EventArgs e)
        {

            switch (lang)
            {
                case "de-de":
                    toolTip1.SetToolTip(renderingbox, "Aktivieren um Rendering-Modus auszuwählen");
                    break;
                case "en":
                    toolTip1.SetToolTip(renderingbox, "Check to select a Rendering mode");
                    break;
            }
        }

        private void renderingbox_CheckedChanged(object sender, EventArgs e)
        {
            if (renderingbox.Checked)
            {
                directxradio.Enabled = true;
                openglradio.Enabled = true;
                swradio.Enabled = true;
            }
            else
            {
                directxradio.Enabled = false;
                openglradio.Enabled = false;
                swradio.Enabled = false;
            }
        }
        private void save()
        {
            string cores = "";
            string prio = "";
            switch (cpu_cores.Text)
            {
                case "Standard":
                case "default":
                    cores = "default";
                    break;
                default:
                    cores = cpu_cores.Text;
                    break;
            }
            switch (cpu_priority.SelectedIndex)
            {
                case 3:
                    prio = "high";
                    break;
                case 2:
                    prio = "normal";
                    break;
                case 1:
                    prio = "low";
                    break;
                case 0:
                    prio = "default";
                    break;
                default:
                    prio = "";
                    break;

            }
            string render_mode = "";    //deklariert render modus
            if (directxradio.Checked)
                render_mode = "DirectX";
            if (openglradio.Checked)
                render_mode = "OpenGL";
            if (swradio.Checked)
                render_mode = "Software";
            if (radioButton1.Checked && profilname_txt.Text != "") // Neues Profil Hinzufügen
            {
                index = index + 1;
                buffer.index.Add(index);
                buffer.name.Add(profilname_txt.Text);
                buffer.custom_res.Add(customresbox.Checked);
                if (customresbox.Checked)
                {
                    buffer.height.Add(Convert.ToInt32(height_txt.Text));
                    buffer.width.Add(Convert.ToInt32(width_txt.Text));
                    buffer.depth.Add(Convert.ToInt32(depth_txt.Text));
                }
                else
                {
                    buffer.height.Add(0);
                    buffer.width.Add(0);
                    buffer.depth.Add(0);

                }
                buffer.rendering.Add(renderingbox.Checked);
                if (renderingbox.Checked)
                {
                    buffer.rendering_mode.Add(render_mode);
                }
                else
                {
                    buffer.rendering_mode.Add("");
                }
                if (windowmode.Checked) { buffer.window_mode.Add(true); }//Fenstermodus
                else { buffer.window_mode.Add(false); }

                buffer.cpu_cores.Add(cores);
                buffer.cpu_priority.Add(prio);

                if (sound_set.Checked) { buffer.sound_off.Add(true); }//Sound
                else { buffer.sound_off.Add(false); }
                if (intro_set.Checked) { buffer.intro_off.Add(true); }//Intro
                else { buffer.intro_off.Add(false); }
                if (autosave.Checked) { buffer.autosave.Add(true); }
                else { buffer.autosave.Add(false); }
                buffer.saveintrvl.Add(decimal.ToInt32(saveintervall.Value));
                if (alt_keys.Checked) { buffer.alt_keys.Add(true); }
                else { buffer.alt_keys.Add(false); }
            }
            else if (radioButton2.Checked) // Profil überschreiben
            {
                Debug.Write(buffer.index);
                int i = 0;
                i = buffer.name.IndexOf(comboBox1.Text);
                if (i != -1)
                {
                    Debug.WriteLine(i);
                    buffer.custom_res[i] = customresbox.Checked;
                    if (customresbox.Checked)
                    {
                        buffer.height[i] = Convert.ToInt32(height_txt.Text);
                        buffer.width[i] = Convert.ToInt32(width_txt.Text);
                        buffer.depth[i] = Convert.ToInt32(depth_txt.Text);
                    }
                    else
                    {
                        buffer.height[i] = 0;
                        buffer.width[i] = 0;
                        buffer.depth[i] = 0;

                    }
                    buffer.rendering[i] = renderingbox.Checked;
                    if (renderingbox.Checked)
                    {
                        buffer.rendering_mode[i] = render_mode;
                    }
                    else
                    {
                        buffer.rendering_mode[i] = "";
                    }
                    if (windowmode.Checked) { buffer.window_mode[i] = true; }//Fenstermodus
                    else { buffer.window_mode[i] = false; }
                    buffer.cpu_cores[i] = cores;
                    buffer.cpu_priority[i] = prio;
                    if (sound_set.Checked) { buffer.sound_off[i] = true; }//Sound
                    else { buffer.sound_off[i] = false; }
                    if (intro_set.Checked) { buffer.intro_off[i] = true; }//intro
                    else { buffer.intro_off[i] = false; }
                    if (autosave.Checked) { buffer.autosave[i] = true; }
                    else { buffer.autosave[i] = false; }
                    buffer.saveintrvl[i] = Decimal.ToInt32(saveintervall.Value);
                    if (alt_keys.Checked) { buffer.alt_keys[i] = true; }
                    else { buffer.alt_keys[i] = false; };
                }



            }
            writer.write();

            Properties.Settings.Default.steam_path = textBox1.Text;
            Properties.Settings.Default.steam_id = Convert.ToInt32(textBox2.Text);
            Properties.Settings.Default.Save();
            Form1 form1 = new Form1();
            form1.close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customresbox.Checked = true;    //ändere Auflösung
            height_txt.Text = Screen.PrimaryScreen.Bounds.Height.ToString(); // Auflösung
            width_txt.Text = Screen.PrimaryScreen.Bounds.Width.ToString();
            depth_txt.Text = Screen.PrimaryScreen.BitsPerPixel.ToString(); //Farbtiefe

            renderingbox.Checked = true;
            directxradio.Checked = true;

            cpu_cores.SelectedIndex = 1;
            cpu_priority.SelectedIndex = 3;
            intro_set.Checked = true;
            autosave.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                Properties.Settings.Default.steam_path = textBox1.Text;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (init == true)
            {
                load_settings();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "") //lösche Einstellungen
            {
                int i = 0;
                i = buffer.name.IndexOf(comboBox1.Text);
                buffer.index.RemoveAt(i);
                buffer.name.RemoveAt(i);
                buffer.custom_res.RemoveAt(i);
                buffer.height.RemoveAt(i);
                buffer.width.RemoveAt(i);
                buffer.depth.RemoveAt(i);
                buffer.rendering.RemoveAt(i);
                buffer.rendering_mode.RemoveAt(i);
                buffer.window_mode.RemoveAt(i);

                buffer.cpu_cores.RemoveAt(i);
                buffer.cpu_priority.RemoveAt(i);

                buffer.sound_off.RemoveAt(i);
                buffer.intro_off.RemoveAt(i);
                buffer.autosave.RemoveAt(i);
                buffer.saveintrvl.RemoveAt(i);
                buffer.alt_keys.RemoveAt(i);
                writer.write();
                Form1 form1 = new Form1();
                form1.close();
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button4, "Entfernt das Ausgewählte Profil");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void autosave_CheckedChanged(object sender, EventArgs e)
        {
            if (autosave.Checked == true)
            {
                saveintervall.Enabled = true;
            }
            else
            {
                saveintervall.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form3.Show();
            form3.Focus();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else { button1.Enabled = false; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form4.Show();
            form4.Focus();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}
