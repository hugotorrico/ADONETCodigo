namespace ADONET7
{
    partial class frmUsuarios
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
            btnListar = new Button();
            dgvUsuarios = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Name2 = new DataGridViewTextBoxColumn();
            FirstLastName = new DataGridViewTextBoxColumn();
            RoleName = new DataGridViewTextBoxColumn();
            txtFiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(53, 63);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(184, 41);
            btnListar.TabIndex = 0;
            btnListar.Text = "BuscarUsuarios";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { UserID, UserName, Email, Name2, FirstLastName, RoleName });
            dgvUsuarios.Location = new Point(53, 145);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 29;
            dgvUsuarios.Size = new Size(969, 188);
            dgvUsuarios.TabIndex = 1;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "UserID";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.Width = 125;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "UserName";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Name2
            // 
            Name2.DataPropertyName = "Name";
            Name2.HeaderText = "Name";
            Name2.MinimumWidth = 6;
            Name2.Name = "Name2";
            Name2.Width = 125;
            // 
            // FirstLastName
            // 
            FirstLastName.DataPropertyName = "FirstLastName";
            FirstLastName.HeaderText = "FirstLastName";
            FirstLastName.MinimumWidth = 6;
            FirstLastName.Name = "FirstLastName";
            FirstLastName.Width = 125;
            // 
            // RoleName
            // 
            RoleName.DataPropertyName = "RoleName";
            RoleName.HeaderText = "RoleName";
            RoleName.MinimumWidth = 6;
            RoleName.Name = "RoleName";
            RoleName.Width = 125;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(273, 70);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(577, 27);
            txtFiltro.TabIndex = 2;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 634);
            Controls.Add(txtFiltro);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnListar);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListar;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Name2;
        private DataGridViewTextBoxColumn FirstLastName;
        private DataGridViewTextBoxColumn RoleName;
        private TextBox txtFiltro;
    }
}