namespace UniversityEnrollment
{
    partial class listpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listpanel));
            this.lvCandidates = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sERIALIZEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINARYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESERIALIZEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bINARYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eXPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRINTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.contextStripEditDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTS = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTS = new System.Windows.Forms.ToolStripMenuItem();
            this.contextStripSort = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortByHighestGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByLowestGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextStripEditDelete.SuspendLayout();
            this.contextStripSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCandidates
            // 
            this.lvCandidates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.lvCandidates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.lvCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCandidates.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvCandidates.ForeColor = System.Drawing.Color.White;
            this.lvCandidates.FullRowSelect = true;
            this.lvCandidates.HideSelection = false;
            this.lvCandidates.Location = new System.Drawing.Point(0, 28);
            this.lvCandidates.Margin = new System.Windows.Forms.Padding(4);
            this.lvCandidates.Name = "lvCandidates";
            this.lvCandidates.Size = new System.Drawing.Size(1285, 629);
            this.lvCandidates.TabIndex = 0;
            this.lvCandidates.UseCompatibleStateImageBehavior = false;
            this.lvCandidates.View = System.Windows.Forms.View.Details;
            this.lvCandidates.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvCandidates_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date of Birth";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-Mail";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Admission Grade";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 40;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sERIALIZEToolStripMenuItem,
            this.dESERIALIZEToolStripMenuItem,
            this.eXPORTToolStripMenuItem,
            this.pRINTToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1325, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // sERIALIZEToolStripMenuItem
            // 
            this.sERIALIZEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bINARYToolStripMenuItem});
            this.sERIALIZEToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sERIALIZEToolStripMenuItem.ForeColor = System.Drawing.Color.SpringGreen;
            this.sERIALIZEToolStripMenuItem.Name = "sERIALIZEToolStripMenuItem";
            this.sERIALIZEToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.sERIALIZEToolStripMenuItem.Text = "SERIALIZE";
            this.sERIALIZEToolStripMenuItem.Click += new System.EventHandler(this.sERIALIZEToolStripMenuItem_Click_1);
            // 
            // bINARYToolStripMenuItem
            // 
            this.bINARYToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bINARYToolStripMenuItem.ForeColor = System.Drawing.Color.SpringGreen;
            this.bINARYToolStripMenuItem.Name = "bINARYToolStripMenuItem";
            this.bINARYToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.bINARYToolStripMenuItem.Text = "BINARY";
            // 
            // dESERIALIZEToolStripMenuItem
            // 
            this.dESERIALIZEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bINARYToolStripMenuItem1});
            this.dESERIALIZEToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dESERIALIZEToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.dESERIALIZEToolStripMenuItem.Name = "dESERIALIZEToolStripMenuItem";
            this.dESERIALIZEToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.dESERIALIZEToolStripMenuItem.Text = "DESERIALIZE";
            // 
            // bINARYToolStripMenuItem1
            // 
            this.bINARYToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bINARYToolStripMenuItem1.ForeColor = System.Drawing.Color.Crimson;
            this.bINARYToolStripMenuItem1.Name = "bINARYToolStripMenuItem1";
            this.bINARYToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.bINARYToolStripMenuItem1.Text = "BINARY";
            this.bINARYToolStripMenuItem1.Click += new System.EventHandler(this.bINARYToolStripMenuItem1_Click);
            // 
            // eXPORTToolStripMenuItem
            // 
            this.eXPORTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eXPORTToolStripMenuItem.Name = "eXPORTToolStripMenuItem";
            this.eXPORTToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.eXPORTToolStripMenuItem.Text = "EXPORT";
            this.eXPORTToolStripMenuItem.Click += new System.EventHandler(this.eXPORTToolStripMenuItem_Click);
            // 
            // pRINTToolStripMenuItem
            // 
            this.pRINTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pRINTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printBtn,
            this.printPreview,
            this.pToolStripMenuItem});
            this.pRINTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pRINTToolStripMenuItem.Name = "pRINTToolStripMenuItem";
            this.pRINTToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.pRINTToolStripMenuItem.Text = "PRINT";
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.printBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(196, 26);
            this.printBtn.Text = "PRINT";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // printPreview
            // 
            this.printPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.printPreview.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.printPreview.Name = "printPreview";
            this.printPreview.Size = new System.Drawing.Size(196, 26);
            this.printPreview.Text = "PRINT PREVIEW";
            this.printPreview.Click += new System.EventHandler(this.printPreview_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.pToolStripMenuItem.Text = "PAGE SETUP";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.toolStripButton1,
            this.deleteButton});
            this.toolStrip1.Location = new System.Drawing.Point(1285, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 629);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = global::UniversityEnrollment.Properties.Resources.icons8_save_30__1_;
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(37, 34);
            this.saveButton.Text = "Save As";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::UniversityEnrollment.Properties.Resources.icons8_edit_30;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 34);
            this.toolStripButton1.Text = "Edit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = global::UniversityEnrollment.Properties.Resources.icons8_delete_30__1_;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(37, 34);
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1325, 657);
            this.mainPanel.TabIndex = 4;
            // 
            // contextStripEditDelete
            // 
            this.contextStripEditDelete.BackColor = System.Drawing.Color.White;
            this.contextStripEditDelete.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.contextStripEditDelete.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextStripEditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTS,
            this.deleteTS});
            this.contextStripEditDelete.Name = "contextStripEditDelete";
            this.contextStripEditDelete.Size = new System.Drawing.Size(128, 52);
            // 
            // editTS
            // 
            this.editTS.Name = "editTS";
            this.editTS.Size = new System.Drawing.Size(127, 24);
            this.editTS.Text = "Edit";
            this.editTS.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteTS
            // 
            this.deleteTS.Name = "deleteTS";
            this.deleteTS.Size = new System.Drawing.Size(127, 24);
            this.deleteTS.Text = "Delete";
            this.deleteTS.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // contextStripSort
            // 
            this.contextStripSort.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.contextStripSort.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextStripSort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByHighestGradeToolStripMenuItem,
            this.sortByLowestGradeToolStripMenuItem,
            this.sortByIDToolStripMenuItem});
            this.contextStripSort.Name = "contextStripSort";
            this.contextStripSort.Size = new System.Drawing.Size(237, 76);
            // 
            // sortByHighestGradeToolStripMenuItem
            // 
            this.sortByHighestGradeToolStripMenuItem.Name = "sortByHighestGradeToolStripMenuItem";
            this.sortByHighestGradeToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.sortByHighestGradeToolStripMenuItem.Text = "Sort by Highest Grade";
            this.sortByHighestGradeToolStripMenuItem.Click += new System.EventHandler(this.sortByHighestGradeToolStripMenuItem_Click);
            // 
            // sortByLowestGradeToolStripMenuItem
            // 
            this.sortByLowestGradeToolStripMenuItem.Name = "sortByLowestGradeToolStripMenuItem";
            this.sortByLowestGradeToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.sortByLowestGradeToolStripMenuItem.Text = "Sort by Lowest Grade";
            this.sortByLowestGradeToolStripMenuItem.Click += new System.EventHandler(this.sortByLowestGradeToolStripMenuItem_Click);
            // 
            // sortByIDToolStripMenuItem
            // 
            this.sortByIDToolStripMenuItem.Name = "sortByIDToolStripMenuItem";
            this.sortByIDToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.sortByIDToolStripMenuItem.Text = "Sort by ID";
            this.sortByIDToolStripMenuItem.Click += new System.EventHandler(this.sortByIDToolStripMenuItem_Click);
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // listpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1325, 657);
            this.Controls.Add(this.lvCandidates);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "listpanel";
            this.Text = "ListOfCandidatesForm";
            this.Load += new System.EventHandler(this.ListOfCandidatesForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextStripEditDelete.ResumeLayout(false);
            this.contextStripSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCandidates;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem sERIALIZEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINARYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESERIALIZEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bINARYToolStripMenuItem1;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem eXPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ContextMenuStrip contextStripEditDelete;
        private System.Windows.Forms.ToolStripMenuItem editTS;
        private System.Windows.Forms.ToolStripMenuItem deleteTS;
        private System.Windows.Forms.ContextMenuStrip contextStripSort;
        private System.Windows.Forms.ToolStripMenuItem sortByHighestGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByLowestGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRINTToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem printPreview;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ToolStripMenuItem printBtn;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}