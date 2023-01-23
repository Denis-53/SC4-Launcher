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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.intro_set = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.saveintervall = new System.Windows.Forms.NumericUpDown();
            this.autosave = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.settings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveintervall)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Checked = true;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // profilname_txt
            // 
            resources.ApplyResources(this.profilname_txt, "profilname_txt");
            this.profilname_txt.Name = "profilname_txt";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // swradio
            // 
            resources.ApplyResources(this.swradio, "swradio");
            this.swradio.Name = "swradio";
            this.swradio.TabStop = true;
            this.swradio.UseVisualStyleBackColor = true;
            // 
            // openglradio
            // 
            resources.ApplyResources(this.openglradio, "openglradio");
            this.openglradio.Name = "openglradio";
            this.openglradio.TabStop = true;
            this.openglradio.UseVisualStyleBackColor = true;
            // 
            // directxradio
            // 
            resources.ApplyResources(this.directxradio, "directxradio");
            this.directxradio.Name = "directxradio";
            this.directxradio.TabStop = true;
            this.directxradio.UseVisualStyleBackColor = true;
            // 
            // renderingbox
            // 
            resources.ApplyResources(this.renderingbox, "renderingbox");
            this.renderingbox.Name = "renderingbox";
            this.renderingbox.UseVisualStyleBackColor = true;
            this.renderingbox.CheckedChanged += new System.EventHandler(this.renderingbox_CheckedChanged);
            this.renderingbox.MouseHover += new System.EventHandler(this.renderingbox_MouseHover);
            // 
            // depth_txt
            // 
            resources.ApplyResources(this.depth_txt, "depth_txt");
            this.depth_txt.FormattingEnabled = true;
            this.depth_txt.Name = "depth_txt";
            // 
            // width_txt
            // 
            resources.ApplyResources(this.width_txt, "width_txt");
            this.width_txt.Name = "width_txt";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // height_txt
            // 
            resources.ApplyResources(this.height_txt, "height_txt");
            this.height_txt.Name = "height_txt";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // customresbox
            // 
            resources.ApplyResources(this.customresbox, "customresbox");
            this.customresbox.Name = "customresbox";
            this.customresbox.UseVisualStyleBackColor = true;
            this.customresbox.CheckedChanged += new System.EventHandler(this.customresbox_CheckedChanged);
            this.customresbox.MouseHover += new System.EventHandler(this.customresbox_MouseHover);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.tabPage1);
            this.settings.Controls.Add(this.tabPage2);
            this.settings.Controls.Add(this.tabPage3);
            this.settings.Controls.Add(this.tabPage4);
            this.settings.Controls.Add(this.tabPage5);
            resources.ApplyResources(this.settings, "settings");
            this.settings.Name = "settings";
            this.settings.SelectedIndex = 0;
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
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // windowmode
            // 
            resources.ApplyResources(this.windowmode, "windowmode");
            this.windowmode.Name = "windowmode";
            this.windowmode.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cpu_priority);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cpu_cores);
            this.tabPage2.Controls.Add(this.label6);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cpu_priority
            // 
            this.cpu_priority.FormattingEnabled = true;
            resources.ApplyResources(this.cpu_priority, "cpu_priority");
            this.cpu_priority.Name = "cpu_priority";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cpu_cores
            // 
            this.cpu_cores.FormattingEnabled = true;
            resources.ApplyResources(this.cpu_cores, "cpu_cores");
            this.cpu_cores.Name = "cpu_cores";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sound_set);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sound_set
            // 
            resources.ApplyResources(this.sound_set, "sound_set");
            this.sound_set.Name = "sound_set";
            this.sound_set.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.intro_set);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // intro_set
            // 
            resources.ApplyResources(this.intro_set, "intro_set");
            this.intro_set.Name = "intro_set";
            this.intro_set.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.saveintervall);
            this.tabPage5.Controls.Add(this.autosave);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // saveintervall
            // 
            resources.ApplyResources(this.saveintervall, "saveintervall");
            this.saveintervall.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.saveintervall.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.saveintervall.Name = "saveintervall";
            this.saveintervall.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // autosave
            // 
            resources.ApplyResources(this.autosave, "autosave");
            this.autosave.Name = "autosave";
            this.autosave.UseVisualStyleBackColor = true;
            this.autosave.CheckedChanged += new System.EventHandler(this.autosave_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // button4
            // 
            this.button4.Image = global::SC4_Launcher.Properties.Resources.Remove;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button5
            // 
            this.button5.Image = global::SC4_Launcher.Properties.Resources.Web;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
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
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saveintervall)).EndInit();
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
        private TabPage tabPage5;
        private Label label9;
        private NumericUpDown saveintervall;
        private CheckBox autosave;
        private Button button5;
    }
}