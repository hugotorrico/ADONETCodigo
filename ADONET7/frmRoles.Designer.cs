namespace ADONET7
{
    partial class frmRoles
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
            btnGrabar = new Button();
            label1 = new Label();
            txtRol = new TextBox();
            btnActualizar = new Button();
            txtIDRol = new TextBox();
            label3 = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(210, 128);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(109, 42);
            btnGrabar.TabIndex = 0;
            btnGrabar.Text = "Registrar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 68);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre Rol";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(428, 65);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(125, 27);
            txtRol.TabIndex = 2;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(325, 128);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(109, 42);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtIDRol
            // 
            txtIDRol.Location = new Point(180, 61);
            txtIDRol.Name = "txtIDRol";
            txtIDRol.Size = new Size(125, 27);
            txtIDRol.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 61);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "IdRol";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(440, 128);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 42);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(label3);
            Controls.Add(txtIDRol);
            Controls.Add(btnActualizar);
            Controls.Add(txtRol);
            Controls.Add(label1);
            Controls.Add(btnGrabar);
            Name = "frmRoles";
            Text = "frmRoles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGrabar;
        private Label label1;
        private TextBox txtRol;
        private Button btnActualizar;
        private TextBox txtIDRol;
        private Label label3;
        private Button btnEliminar;
    }
}