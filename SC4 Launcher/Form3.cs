using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SC4_Launcher
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            if (Properties.Settings.Default.language == "")
            {
                this.ControlBox = false;
            }
            else
            {
                this.ControlBox = true;
            }
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.language);
            InitializeComponent();
            switch (Properties.Settings.Default.language)
            {
                case "de-de":
                    comboBox1.SelectedIndex = 1;
                    break;
                case "en":
                    comboBox1.SelectedIndex = 0;
                    break;
                default:
                    comboBox1.SelectedIndex = 0;
                    break;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
                this.Hide();
                this.Parent = null;
                e.Cancel = true;

        }

        private void save_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "English":
                    Properties.Settings.Default.language = "en";
                    break;
                case "Deutsch":
                    Properties.Settings.Default.language = "de-de";
                    break;
            }
            Properties.Settings.Default.Save();
            Form1 form = new Form1();
            form.close();
        }
    }
}
