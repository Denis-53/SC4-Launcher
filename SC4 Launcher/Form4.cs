using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC4_Launcher
{
    public partial class Form4 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        bool btn_3cl = false;
        bool btn_4cl = false;
        char alt_key_end;
        char alt_key_pos1;

        public Form4()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.sc4_mapper_path;
            checkBox1.Checked = Properties.Settings.Default.sc4_mapper_on;
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
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && textBox1.Text == "")
            {
                MessageBox.Show("Bitte Pfad zuerst eingeben", "Kein Pfad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Properties.Settings.Default.sc4_mapper_on = checkBox1.Checked;
                Properties.Settings.Default.sc4_mapper_path = textBox1.Text;
                Properties.Settings.Default.alt_key_end = alt_key_end;
                Properties.Settings.Default.alt_key_pos1 = alt_key_pos1;
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn_3cl = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_4cl= true;
        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btn_3cl == true)
            {
                alt_key_end = e.KeyChar;
                button3.Text = Convert.ToString(alt_key_end);
                btn_3cl= false;
            }
            else if (btn_4cl == true)
            {
                alt_key_pos1= e.KeyChar;
                button4.Text = Convert.ToString(alt_key_pos1);
                btn_4cl = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.alt_key_end = default;
            Properties.Settings.Default.alt_key_pos1 = default;
<<<<<<< HEAD
            if (Properties.Settings.Default.language == "de-de")
            {
                button3.Text = "Taste drücken";
                button4.Text = "Taste drücken";
            }
            else
            {
                button3.Text = "press a key";
                button4.Text = "press a key";
            }
=======
            button3.Text = "Taste drücken";
            button4.Text = "Taste drücken";
>>>>>>> 9a098a6572d6421af8f5fdf106fe0a7ce6e7440f
        }
    }
}
