namespace SC4_Launcher
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            groupBox1 = new GroupBox();
            button5 = new Button();
            label3 = new Label();
            button4 = new Button();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            visible = new DataGridViewCheckBoxColumn();
            icon = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            path = new DataGridViewTextBoxColumn();
            toolStripButton3 = new ToolStripButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toolStrip1);
            groupBox2.Controls.Add(dataGridView1);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            resources.ApplyResources(toolStrip1, "toolStrip1");
            toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.add15;
            resources.ApplyResources(toolStripButton1, "toolStripButton1");
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.remove15;
            resources.ApplyResources(toolStripButton2, "toolStripButton2");
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { visible, icon, name, path });
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            // 
            // visible
            // 
            visible.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            visible.DataPropertyName = "visible";
            visible.FillWeight = 50F;
            resources.ApplyResources(visible, "visible");
            visible.Name = "visible";
            visible.Resizable = DataGridViewTriState.False;
            // 
            // icon
            // 
            icon.DataPropertyName = "icon";
            icon.FillWeight = 47.6715965F;
            resources.ApplyResources(icon, "icon");
            icon.ImageLayout = DataGridViewImageCellLayout.Stretch;
            icon.Name = "icon";
            icon.ReadOnly = true;
            icon.Resizable = DataGridViewTriState.False;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            name.DataPropertyName = "name";
            name.FillWeight = 140.6312F;
            resources.ApplyResources(name, "name");
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.True;
            // 
            // path
            // 
            path.DataPropertyName = "path";
            path.FillWeight = 140.6312F;
            resources.ApplyResources(path, "path");
            path.Name = "path";
            path.ReadOnly = true;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.folder16;
            resources.ApplyResources(toolStripButton3, "toolStripButton3");
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // Form4
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form4";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Label label3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn visible;
        private DataGridViewImageColumn icon;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn path;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}