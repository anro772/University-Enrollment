namespace UniversityEnrollment
{
    partial class EditCandidateForm
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tbSecondaryGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMainGrade = new System.Windows.Forms.TextBox();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.tbDateOfBirth = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.editCandidateButton = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.labelFirstName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.labelFirstName.ForeColor = System.Drawing.Color.White;
            this.labelFirstName.Location = new System.Drawing.Point(233, 157);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(103, 22);
            this.labelFirstName.TabIndex = 31;
            this.labelFirstName.Text = "First Name";
            // 
            // tbSecondaryGrade
            // 
            this.tbSecondaryGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSecondaryGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.tbSecondaryGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSecondaryGrade.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecondaryGrade.ForeColor = System.Drawing.Color.DarkGray;
            this.tbSecondaryGrade.Location = new System.Drawing.Point(226, 231);
            this.tbSecondaryGrade.Margin = new System.Windows.Forms.Padding(4);
            this.tbSecondaryGrade.Name = "tbSecondaryGrade";
            this.tbSecondaryGrade.Size = new System.Drawing.Size(371, 28);
            this.tbSecondaryGrade.TabIndex = 30;
            this.tbSecondaryGrade.Text = "0, 1, 2..";
            this.tbSecondaryGrade.Validating += new System.ComponentModel.CancelEventHandler(this.tbSecondaryGrade_Validating);
            this.tbSecondaryGrade.Validated += new System.EventHandler(this.tbSecondaryGrade_Validated);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(233, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Secondary Grade";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(233, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Main Grade";
            // 
            // tbMainGrade
            // 
            this.tbMainGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMainGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.tbMainGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMainGrade.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMainGrade.ForeColor = System.Drawing.Color.DarkGray;
            this.tbMainGrade.Location = new System.Drawing.Point(226, 191);
            this.tbMainGrade.Margin = new System.Windows.Forms.Padding(4);
            this.tbMainGrade.Name = "tbMainGrade";
            this.tbMainGrade.Size = new System.Drawing.Size(371, 28);
            this.tbMainGrade.TabIndex = 29;
            this.tbMainGrade.Text = "0, 1, 2..";
            this.tbMainGrade.Validating += new System.ComponentModel.CancelEventHandler(this.tbMainGrade_Validating);
            this.tbMainGrade.Validated += new System.EventHandler(this.tbMainGrade_Validated);
            // 
            // tbEMail
            // 
            this.tbEMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.tbEMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEMail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEMail.ForeColor = System.Drawing.Color.DarkGray;
            this.tbEMail.Location = new System.Drawing.Point(226, 150);
            this.tbEMail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(371, 28);
            this.tbEMail.TabIndex = 22;
            this.tbEMail.Text = "something@mail.com";
            this.tbEMail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEMail_Validating);
            this.tbEMail.Validated += new System.EventHandler(this.tbEMail_Validated);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 287);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "E-Mail";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.labelDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.labelDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.labelDateOfBirth.Location = new System.Drawing.Point(233, 245);
            this.labelDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(123, 22);
            this.labelDateOfBirth.TabIndex = 33;
            this.labelDateOfBirth.Text = "Date of Birth";
            // 
            // tbDateOfBirth
            // 
            this.tbDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.tbDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDateOfBirth.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateOfBirth.ForeColor = System.Drawing.Color.DarkGray;
            this.tbDateOfBirth.Location = new System.Drawing.Point(226, 108);
            this.tbDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.tbDateOfBirth.Name = "tbDateOfBirth";
            this.tbDateOfBirth.Size = new System.Drawing.Size(371, 28);
            this.tbDateOfBirth.TabIndex = 17;
            this.tbDateOfBirth.Text = "DD/MM/YYYY";
            this.tbDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.tbDateOfBirth_Validating);
            this.tbDateOfBirth.Validated += new System.EventHandler(this.tbDateOfBirth_Validated);
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLastName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbLastName.Location = new System.Drawing.Point(226, 66);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(371, 28);
            this.tbLastName.TabIndex = 16;
            this.tbLastName.Text = "Last Name";
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            this.tbLastName.Validated += new System.EventHandler(this.tbLastName_Validated);
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.labelLastName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.labelLastName.ForeColor = System.Drawing.Color.White;
            this.labelLastName.Location = new System.Drawing.Point(233, 201);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(107, 22);
            this.labelLastName.TabIndex = 32;
            this.labelLastName.Text = "Last Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFirstName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbFirstName.Location = new System.Drawing.Point(226, 22);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(371, 28);
            this.tbFirstName.TabIndex = 12;
            this.tbFirstName.Tag = "";
            this.tbFirstName.Text = "First Name";
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            this.tbFirstName.Validated += new System.EventHandler(this.tbFirstName_Validated);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.panel3.Location = new System.Drawing.Point(200, 491);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 15);
            this.panel3.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(42)))), ((int)(((byte)(76)))));
            this.panel2.Location = new System.Drawing.Point(200, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 362);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.tbSecondaryGrade);
            this.panel1.Controls.Add(this.tbMainGrade);
            this.panel1.Controls.Add(this.tbEMail);
            this.panel1.Controls.Add(this.tbDateOfBirth);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.editCandidateButton);
            this.panel1.Location = new System.Drawing.Point(205, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 365);
            this.panel1.TabIndex = 35;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.closeButton.FlatAppearance.BorderSize = 3;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(454, 278);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(158, 62);
            this.closeButton.TabIndex = 31;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // editCandidateButton
            // 
            this.editCandidateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editCandidateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.editCandidateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.editCandidateButton.FlatAppearance.BorderSize = 3;
            this.editCandidateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.editCandidateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCandidateButton.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCandidateButton.ForeColor = System.Drawing.Color.White;
            this.editCandidateButton.Location = new System.Drawing.Point(32, 278);
            this.editCandidateButton.Margin = new System.Windows.Forms.Padding(4);
            this.editCandidateButton.Name = "editCandidateButton";
            this.editCandidateButton.Size = new System.Drawing.Size(347, 62);
            this.editCandidateButton.TabIndex = 25;
            this.editCandidateButton.Text = "Edit Candidate";
            this.editCandidateButton.UseVisualStyleBackColor = false;
            this.editCandidateButton.Click += new System.EventHandler(this.editCandidateButton_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // EditCandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1325, 657);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCandidateForm";
            this.Text = "EditCandidateForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox tbSecondaryGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMainGrade;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox tbDateOfBirth;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editCandidateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}