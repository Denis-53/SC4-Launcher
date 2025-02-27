using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SC4_Launcher
{
    public partial class Form4 : Form
    {
        OpenFileDialog opnfd = new OpenFileDialog();
        Toolbar toolbar = new Toolbar();
        bool btn_3cl = false;
        bool btn_4cl = false;
        char alt_key_end;
        char alt_key_pos1;

        public Form4()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Columns[0].Width = 45; // Erste Spalte auf 100 Pixel setzen
            dataGridView1.Columns[1].Width = 23; // Erste Spalte auf 100 Pixel setzen
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 23; // Setzt die Höhe aller Zeilen auf 50 Pixel
            dataGridView1.Columns["visible"].ReadOnly = false;
            dataGridView1.Columns["name"].ReadOnly = false;
            opnfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opnfd.Filter = "EXE |*.exe";
            opnfd.Title = "Anwendungspfad";


            if (Properties.Settings.Default.language == "en")
            {
                dataGridView1.Columns[0].HeaderText = "visible";
                dataGridView1.Columns[1].HeaderText = " ";
                dataGridView1.Columns[2].HeaderText = "name";
                dataGridView1.Columns[3].HeaderText = "path";
                opnfd.Title = "Program path";
            }
            if (Properties.Settings.Default.alt_key_end != default) { button3.Text = Properties.Settings.Default.alt_key_end.ToString(); }
            if (Properties.Settings.Default.alt_key_pos1 != default) { button4.Text = Properties.Settings.Default.alt_key_pos1.ToString(); }

            this.KeyPreview = true; // Enable form-level key events
            this.KeyPress += Form4_KeyPress;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolbar.save_toolbar();
            Properties.Settings.Default.alt_key_end = alt_key_end;
            Properties.Settings.Default.alt_key_pos1 = alt_key_pos1;
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_3cl = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_4cl = true;
        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btn_3cl == true)
            {
                alt_key_end = e.KeyChar;
                button3.Text = Convert.ToString(alt_key_end);
                btn_3cl = false;
            }
            else if (btn_4cl == true)
            {
                alt_key_pos1 = e.KeyChar;
                button4.Text = Convert.ToString(alt_key_pos1);
                btn_4cl = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.alt_key_end = default;
            Properties.Settings.Default.alt_key_pos1 = default;

            if (Properties.Settings.Default.language == "de-de")
            {
                button3.Text = "Taste drücken";
                button4.Text = "Taste drücken";
            }
            else if (Properties.Settings.Default.language == "en")
            {
                button3.Text = "press a key";
                button4.Text = "press a key";
            }

        }


        private void Form4_Load(object sender, EventArgs e)
        {
            if (Toolbar.bar_elements.Count > 0) // Nur aktualisieren, wenn Daten vorhanden sind
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Toolbar.bar_elements;
                dataGridView1.ClearSelection();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                Toolbar.bar_elements.Add(new Toolbar_struct { visible = true, icon = toolbar.geticon(opnfd.FileName), name = opnfd.SafeFileName, path = opnfd.FileName });
                refresh_data();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;

            if (selectedIndex >= 0) // Prüfen, ob eine Auswahl existiert
            {
                Toolbar.bar_elements.RemoveAt(selectedIndex); // Entferne Element aus der Liste
                refresh_data();

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
        private void refresh_data()
        {
            if (Toolbar.bar_elements.Count > 0) // Nur aktualisieren, wenn Daten vorhanden sind
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Toolbar.bar_elements;
                dataGridView1.ClearSelection();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;

            if (selectedIndex >= 0) // Prüfen, ob eine Auswahl existiert
            {
                string folder = Path.GetDirectoryName(dataGridView1.Rows[selectedIndex].Cells["path"].Value.ToString());
                Process.Start("explorer.exe", folder);

            }
            
        }
    }
}
