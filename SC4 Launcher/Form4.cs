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
        public Form4()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.sc4_mapper_path;

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
                MessageBox.Show("Bitte Pfad zu erst eingeben", "Kein Pfad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Properties.Settings.Default.sc4_mapper_on = checkBox1.Checked;
                Properties.Settings.Default.sc4_mapper_path = textBox1.Text;
                this.Close();
            }
        }
    }
}
