namespace ADONET7
{
    partial class frmUsuarioRol
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
            txtRol = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            txtFirstLastName = new TextBox();
            txtUserName = new TextBox();
            txtSecondLastName = new TextBox();
            txtClinicID = new TextBox();
            txtFirma = new TextBox();
            txtEmail = new TextBox();
            txtRegionID = new TextBox();
            btnGrabar = new Button();
            txtPassword = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // txtRol
            // 
            txtRol.Location = new Point(115, 19);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(125, 27);
            txtRol.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 160);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 89);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(575, 89);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 156);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 8;
            label5.Text = "FirstLastName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(542, 156);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 9;
            label6.Text = "SecondLastName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 223);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 10;
            label7.Text = "RegionID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(301, 223);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 11;
            label8.Text = "Firma";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(542, 233);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 12;
            label9.Text = "ClinicID";
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 153);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 14;
            // 
            // txtFirstLastName
            // 
            txtFirstLastName.Location = new Point(404, 153);
            txtFirstLastName.Name = "txtFirstLastName";
            txtFirstLastName.Size = new Size(125, 27);
            txtFirstLastName.TabIndex = 15;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(115, 89);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 16;
            // 
            // txtSecondLastName
            // 
            txtSecondLastName.Location = new Point(693, 153);
            txtSecondLastName.Name = "txtSecondLastName";
            txtSecondLastName.Size = new Size(125, 27);
            txtSecondLastName.TabIndex = 17;
            // 
            // txtClinicID
            // 
            txtClinicID.Location = new Point(693, 223);
            txtClinicID.Name = "txtClinicID";
            txtClinicID.Size = new Size(125, 27);
            txtClinicID.TabIndex = 18;
            txtClinicID.Text = "96";
            // 
            // txtFirma
            // 
            txtFirma.Location = new Point(404, 230);
            txtFirma.Name = "txtFirma";
            txtFirma.Size = new Size(125, 27);
            txtFirma.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(696, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 20;
            // 
            // txtRegionID
            // 
            txtRegionID.Location = new Point(115, 223);
            txtRegionID.Name = "txtRegionID";
            txtRegionID.Size = new Size(125, 27);
            txtRegionID.TabIndex = 22;
            txtRegionID.Text = "5";
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(319, 295);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(109, 42);
            btnGrabar.TabIndex = 23;
            btnGrabar.Text = "Registrar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(400, 92);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(301, 92);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 24;
            label10.Text = "Password";
            // 
            // frmUsuarioRol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 450);
            Controls.Add(txtPassword);
            Controls.Add(label10);
            Controls.Add(btnGrabar);
            Controls.Add(txtRegionID);
            Controls.Add(txtEmail);
            Controls.Add(txtFirma);
            Controls.Add(txtClinicID);
            Controls.Add(txtSecondLastName);
            Controls.Add(txtUserName);
            Controls.Add(txtFirstLastName);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRol);
            Controls.Add(label1);
            Name = "frmUsuarioRol";
            Text = "frmUsuarioRol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRol;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtName;
        private TextBox txtFirstLastName;
        private TextBox txtUserName;
        private TextBox txtSecondLastName;
        private TextBox txtClinicID;
        private TextBox txtFirma;
        private TextBox txtEmail;
        private TextBox txtRegionID;
        private Button btnGrabar;
        private TextBox txtPassword;
        private Label label10;
    }
}