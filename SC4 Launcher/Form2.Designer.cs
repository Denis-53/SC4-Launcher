namespace SC4_Launcher
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.profilname_txt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.swradio = new System.Windows.Forms.RadioButton();
            this.openglradio = new System.Windows.Forms.RadioButton();
            this.directxradio = new System.Windows.Forms.RadioButton();
            this.renderingbox = new System.Windows.Forms.CheckBox();
            this.depth_txt = new System.Windows.Forms.ComboBox();
            this.width_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.height_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customresbox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.windowmode = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cpu_priority = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cpu_cores = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sound_set = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.intro_set = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.settings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "neues Profil";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(112, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Profil bearbeiten";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // profilname_txt
            // 
            this.profilname_txt.Enabled = false;
            this.profilname_txt.Location = new System.Drawing.Point(130, 12);
            this.profilname_txt.Name = "profilname_txt";
            this.profilname_txt.Size = new System.Drawing.Size(136, 23);
            this.profilname_txt.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // swradio
            // 
            this.swradio.AutoSize = true;
            this.swradio.Enabled = false;
            this.swradio.Location = new System.Drawing.Point(165, 84);
            this.swradio.Name = "swradio";
            this.swradio.Size = new System.Drawing.Size(71, 19);
            this.swradio.TabIndex = 11;
            this.swradio.TabStop = true;
            this.swradio.Text = "Software";
            this.swradio.UseVisualStyleBackColor = true;
            // 
            // openglradio
            // 
            this.openglradio.AutoSize = true;
            this.openglradio.Enabled = false;
            this.openglradio.Location = new System.Drawing.Point(165, 55);
            this.openglradio.Name = "openglradio";
            this.openglradio.Size = new System.Drawing.Size(68, 19);
            this.openglradio.TabIndex = 10;
            this.openglradio.TabStop = true;
            this.openglradio.Text = "OpenGL";
            this.openglradio.UseVisualStyleBackColor = true;
            // 
            // directxradio
            // 
            this.directxradio.AutoSize = true;
            this.directxradio.Enabled = false;
            this.directxradio.Location = new System.Drawing.Point(165, 26);
            this.directxradio.Name = "directxradio";
            this.directxradio.Size = new System.Drawing.Size(63, 19);
            this.directxradio.TabIndex = 9;
            this.directxradio.TabStop = true;
            this.directxradio.Text = "DirectX";
            this.directxradio.UseVisualStyleBackColor = true;
            // 
            // renderingbox
            // 
            this.renderingbox.AutoSize = true;
            this.renderingbox.Location = new System.Drawing.Point(165, 6);
            this.renderingbox.Name = "renderingbox";
            this.renderingbox.Size = new System.Drawing.Size(117, 19);
            this.renderingbox.TabIndex = 8;
            this.renderingbox.Text = "rendering Modus";
            this.renderingbox.UseVisualStyleBackColor = true;
            this.renderingbox.CheckedChanged += new System.EventHandler(this.renderingbox_CheckedChanged);
            this.renderingbox.MouseHover += new System.EventHandler(this.renderingbox_MouseHover);
            // 
            // depth_txt
            // 
            this.depth_txt.Enabled = false;
            this.depth_txt.FormattingEnabled = true;
            this.depth_txt.Location = new System.Drawing.Point(48, 83);
            this.depth_txt.Name = "depth_txt";
            this.depth_txt.Size = new System.Drawing.Size(82, 23);
            this.depth_txt.TabIndex = 7;
            // 
            // width_txt
            // 
            this.width_txt.Enabled = false;
            this.width_txt.Location = new System.Drawing.Point(48, 54);
            this.width_txt.Name = "width_txt";
            this.width_txt.Size = new System.Drawing.Size(82, 23);
            this.width_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiefe";
            // 
            // height_txt
            // 
            this.height_txt.Enabled = false;
            this.height_txt.Location = new System.Drawing.Point(48, 25);
            this.height_txt.Name = "height_txt";
            this.height_txt.Size = new System.Drawing.Size(82, 23);
            this.height_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Breite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Höhe";
            // 
            // customresbox
            // 
            this.customresbox.AutoSize = true;
            this.customresbox.Location = new System.Drawing.Point(6, 6);
            this.customresbox.Name = "customresbox";
            this.customresbox.Size = new System.Drawing.Size(81, 19);
            this.customresbox.TabIndex = 0;
            this.customresbox.Text = "Auflösung";
            this.customresbox.UseVisualStyleBackColor = true;
            this.customresbox.CheckedChanged += new System.EventHandler(this.customresbox_CheckedChanged);
            this.customresbox.MouseHover += new System.EventHandler(this.customresbox_MouseHover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "empfohlene Einstellungen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Speichern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.tabPage1);
            this.settings.Controls.Add(this.tabPage2);
            this.settings.Controls.Add(this.tabPage3);
            this.settings.Controls.Add(this.tabPage4);
            this.settings.Location = new System.Drawing.Point(12, 89);
            this.settings.Name = "settings";
            this.settings.SelectedIndex = 0;
            this.settings.Size = new System.Drawing.Size(330, 243);
            this.settings.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.windowmode);
            this.tabPage1.Controls.Add(this.swradio);
            this.tabPage1.Controls.Add(this.customresbox);
            this.tabPage1.Controls.Add(this.openglradio);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.directxradio);
            this.tabPage1.Controls.Add(this.height_txt);
            this.tabPage1.Controls.Add(this.renderingbox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.depth_txt);
            this.tabPage1.Controls.Add(this.width_txt);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grafik";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // windowmode
            // 
            this.windowmode.AutoSize = true;
            this.windowmode.Location = new System.Drawing.Point(7, 124);
            this.windowmode.Name = "windowmode";
            this.windowmode.Size = new System.Drawing.Size(101, 19);
            this.windowmode.TabIndex = 12;
            this.windowmode.Text = "Fenstermodus";
            this.windowmode.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cpu_priority);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cpu_cores);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(322, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CPU";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cpu_priority
            // 
            this.cpu_priority.FormattingEnabled = true;
            this.cpu_priority.Location = new System.Drawing.Point(81, 45);
            this.cpu_priority.Name = "cpu_priority";
            this.cpu_priority.Size = new System.Drawing.Size(82, 23);
            this.cpu_priority.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Priorität";
            // 
            // cpu_cores
            // 
            this.cpu_cores.FormattingEnabled = true;
            this.cpu_cores.Location = new System.Drawing.Point(81, 8);
            this.cpu_cores.Name = "cpu_cores";
            this.cpu_cores.Size = new System.Drawing.Size(82, 23);
            this.cpu_cores.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Anzahl CPU";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sound_set);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(322, 215);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sound";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sound_set
            // 
            this.sound_set.AutoSize = true;
            this.sound_set.Location = new System.Drawing.Point(6, 6);
            this.sound_set.Name = "sound_set";
            this.sound_set.Size = new System.Drawing.Size(132, 19);
            this.sound_set.TabIndex = 0;
            this.sound_set.Text = "Sounds deaktivieren";
            this.sound_set.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.intro_set);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(322, 215);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Game";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Erweitert";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 1;
            // 
            // intro_set
            // 
            this.intro_set.AutoSize = true;
            this.intro_set.Location = new System.Drawing.Point(6, 6);
            this.intro_set.Name = "intro_set";
            this.intro_set.Size = new System.Drawing.Size(118, 19);
            this.intro_set.TabIndex = 0;
            this.intro_set.Text = "Intro deaktivieren";
            this.intro_set.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Steam Pfad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 23);
            this.textBox1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Öffnen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "App-ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 368);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 23);
            this.textBox2.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Image = global::SC4_Launcher.Properties.Resources.Remove;
            this.button4.Location = new System.Drawing.Point(272, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.profilname_txt);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Profil bearbeiten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.settings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox profilname_txt;
        private ComboBox comboBox1;
        private ComboBox depth_txt;
        private TextBox width_txt;
        private Label label3;
        private TextBox height_txt;
        private Label label2;
        private Label label1;
        private CheckBox customresbox;
        private ToolTip toolTip1;
        private RadioButton swradio;
        private RadioButton openglradio;
        private RadioButton directxradio;
        private CheckBox renderingbox;
        private Button button1;
        private Button button2;
        private TabControl settings;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private CheckBox windowmode;
        private Label label4;
        private TextBox textBox1;
        private Button button3;
        private Label label5;
        private TextBox textBox2;
        private ComboBox cpu_priority;
        private Label label7;
        private ComboBox cpu_cores;
        private Label label6;
        private TabPage tabPage3;
        private Button button4;
        private TabPage tabPage4;
        private CheckBox sound_set;
        private CheckBox intro_set;
        private Label label8;
        private Panel panel1;
    }
}