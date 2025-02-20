using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC4_Launcher
{
    public partial class Form5 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        Toolbar toolbar = new Toolbar();
        int selectedIndex;
        public Form5()
        {
            InitializeComponent();
            comboBox1.DataSource = Toolbar.bar_elements;
            comboBox1.DisplayMember = "name"; // Das Feld, das angezeigt wird
            comboBox1.ValueMember = "path"; // Wert, den man im Code nutzen kann
            selectedIndex = comboBox1.SelectedIndex;

            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            ofd.Filter = "EXE |*.exe";
            ofd.Title = "Anwendungspfad";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                Toolbar.bar_elements.Add(new Toolbar_struct { visible = true, icon = toolbar.geticon(textBox1.Text), name = textBox2.Text, path = textBox1.Text });
                this.Close();
            }
            else
            {
                if (Properties.Settings.Default.language == "en")
                {
                    MessageBox.Show("Please select a Program!");
                }
                else
                {
                    MessageBox.Show("Bitte eine Anwendung auswählen!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            if (selectedIndex >= 0) // Prüfen, ob eine Auswahl existiert
            {
                Toolbar.bar_elements.RemoveAt(selectedIndex); // Entferne Element aus der Liste
                this.Close();
            }
            else
            {
                if (Properties.Settings.Default.language == "en")
                {
                    MessageBox.Show("Please select a entry!");
                }
                else
                {
                    MessageBox.Show("Bitte einen Eintrag auswählen!");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                textBox2.Text = ofd.SafeFileName;

                Icon icon = Icon.ExtractAssociatedIcon(ofd.FileName);
                if (icon != null)
                {
                    pictureBox1.Image = icon.ToBitmap(); // Icon in Bitmap konvertieren
                }

            }
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
