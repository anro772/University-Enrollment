namespace UniversityEnrollment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.mainpanel = new System.Windows.Forms.Panel();
            this.maintimer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.closeButtonControl1 = new UserControlLibrary.CloseButtonControl();
            this.minimizeButtonControl1 = new UserControlLibrary.MinimizeButtonControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.dataGridButton = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.sidebar.Controls.Add(this.menuButton);
            this.sidebar.Controls.Add(this.listButton);
            this.sidebar.Controls.Add(this.addButton);
            this.sidebar.Controls.Add(this.statisticsButton);
            this.sidebar.Controls.Add(this.dataGridButton);
            this.sidebar.Location = new System.Drawing.Point(0, 31);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar.MaximumSize = new System.Drawing.Size(253, 1329);
            this.sidebar.MinimumSize = new System.Drawing.Size(76, 20);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(253, 626);
            this.sidebar.TabIndex = 13;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.mainpanel.Location = new System.Drawing.Point(249, 35);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainpanel.MaximumSize = new System.Drawing.Size(1253, 1329);
            this.mainpanel.MinimumSize = new System.Drawing.Size(1076, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1076, 622);
            this.mainpanel.TabIndex = 14;
            // 
            // maintimer
            // 
            this.maintimer.Interval = 10;
            this.maintimer.Tick += new System.EventHandler(this.maintimer_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.closeButtonControl1);
            this.flowLayoutPanel1.Controls.Add(this.minimizeButtonControl1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1325, 35);
            this.flowLayoutPanel1.TabIndex = 15;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            // 
            // closeButtonControl1
            // 
            this.closeButtonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.closeButtonControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closeButtonControl1.Location = new System.Drawing.Point(1272, 3);
            this.closeButtonControl1.Name = "closeButtonControl1";
            this.closeButtonControl1.Size = new System.Drawing.Size(50, 30);
            this.closeButtonControl1.TabIndex = 0;
            // 
            // minimizeButtonControl1
            // 
            this.minimizeButtonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.minimizeButtonControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimizeButtonControl1.Location = new System.Drawing.Point(1216, 3);
            this.minimizeButtonControl1.Name = "minimizeButtonControl1";
            this.minimizeButtonControl1.Size = new System.Drawing.Size(50, 30);
            this.minimizeButtonControl1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeApplicationToolStripMenuItem,
            this.goToMenuToolStripMenuItem,
            this.goToListToolStripMenuItem,
            this.goToAddToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 100);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.closeApplicationToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.closeApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // goToMenuToolStripMenuItem
            // 
            this.goToMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.goToMenuToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.goToMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.goToMenuToolStripMenuItem.Name = "goToMenuToolStripMenuItem";
            this.goToMenuToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.goToMenuToolStripMenuItem.Text = "Go to Menu";
            this.goToMenuToolStripMenuItem.Click += new System.EventHandler(this.goToMenuToolStripMenuItem_Click);
            // 
            // goToListToolStripMenuItem
            // 
            this.goToListToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.goToListToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.goToListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.goToListToolStripMenuItem.Name = "goToListToolStripMenuItem";
            this.goToListToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.goToListToolStripMenuItem.Text = "Go to List";
            this.goToListToolStripMenuItem.Click += new System.EventHandler(this.goToListToolStripMenuItem_Click);
            // 
            // goToAddToolStripMenuItem
            // 
            this.goToAddToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.goToAddToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.goToAddToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.goToAddToolStripMenuItem.Name = "goToAddToolStripMenuItem";
            this.goToAddToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.goToAddToolStripMenuItem.Text = "Go to Add";
            this.goToAddToolStripMenuItem.Click += new System.EventHandler(this.goToAddToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityEnrollment.Properties.Resources.icons8_windows_xp_30;
            this.pictureBox1.InitialImage = global::UniversityEnrollment.Properties.Resources.Logo_ASE_Bucharest1;
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1170, 1, 0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Image = global::UniversityEnrollment.Properties.Resources.icons8_menu_36;
            this.menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.Location = new System.Drawing.Point(4, 4);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.menuButton.Size = new System.Drawing.Size(249, 112);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "       Menu";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // listButton
            // 
            this.listButton.FlatAppearance.BorderSize = 0;
            this.listButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listButton.ForeColor = System.Drawing.Color.White;
            this.listButton.Image = global::UniversityEnrollment.Properties.Resources.icons8_save_to_grid_39__1_;
            this.listButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listButton.Location = new System.Drawing.Point(4, 124);
            this.listButton.Margin = new System.Windows.Forms.Padding(4);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(249, 112);
            this.listButton.TabIndex = 1;
            this.listButton.Text = "       List of              Students";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Image = global::UniversityEnrollment.Properties.Resources.icons8_add_39__2_;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(4, 244);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(249, 112);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "       Add                     Candidate";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.FlatAppearance.BorderSize = 0;
            this.statisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.ForeColor = System.Drawing.Color.White;
            this.statisticsButton.Image = global::UniversityEnrollment.Properties.Resources.icons8_barchart_39;
            this.statisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsButton.Location = new System.Drawing.Point(4, 364);
            this.statisticsButton.Margin = new System.Windows.Forms.Padding(4);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(248, 112);
            this.statisticsButton.TabIndex = 3;
            this.statisticsButton.Text = "       View               Statistics";
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // dataGridButton
            // 
            this.dataGridButton.FlatAppearance.BorderSize = 0;
            this.dataGridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridButton.ForeColor = System.Drawing.Color.White;
            this.dataGridButton.Image = global::UniversityEnrollment.Properties.Resources.icons8_data_sheet_39;
            this.dataGridButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataGridButton.Location = new System.Drawing.Point(4, 484);
            this.dataGridButton.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridButton.Name = "dataGridButton";
            this.dataGridButton.Size = new System.Drawing.Size(248, 112);
            this.dataGridButton.TabIndex = 4;
            this.dataGridButton.Text = "   Data Grid";
            this.dataGridButton.UseVisualStyleBackColor = true;
            this.dataGridButton.Click += new System.EventHandler(this.dataGridButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1325, 657);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.sidebar);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidate Enrollment";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            //this.Resize += new System.EventHandler(this.Form1_Resize);
            this.sidebar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Timer maintimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControlLibrary.CloseButtonControl closeButtonControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToAddToolStripMenuItem;
        private UserControlLibrary.MinimizeButtonControl minimizeButtonControl1;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button dataGridButton;
        //private UserControls.CloseButtonControl closeButtonControl1;
    }
}

