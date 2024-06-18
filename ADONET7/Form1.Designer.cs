namespace ADONET7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnListar = new Button();
            dgvDemo = new DataGridView();
            ClinicID = new DataGridViewTextBoxColumn();
            ClinicName = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDemo).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(114, 76);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(112, 37);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar DR";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvDemo
            // 
            dgvDemo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDemo.Columns.AddRange(new DataGridViewColumn[] { ClinicID, ClinicName, cantidad });
            dgvDemo.Location = new Point(114, 160);
            dgvDemo.Name = "dgvDemo";
            dgvDemo.RowTemplate.Height = 25;
            dgvDemo.Size = new Size(385, 150);
            dgvDemo.TabIndex = 1;
            // 
            // ClinicID
            // 
            ClinicID.DataPropertyName = "ClinicID";
            ClinicID.HeaderText = "ClinicID";
            ClinicID.Name = "ClinicID";
            // 
            // ClinicName
            // 
            ClinicName.DataPropertyName = "ClinicName";
            ClinicName.HeaderText = "ClinicName";
            ClinicName.Name = "ClinicName";
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "cantidad";
            cantidad.HeaderText = "cantidad";
            cantidad.Name = "cantidad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDemo);
            Controls.Add(btnListar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDemo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnListar;
        private DataGridView dgvDemo;
        private DataGridViewTextBoxColumn ClinicID;
        private DataGridViewTextBoxColumn ClinicName;
        private DataGridViewTextBoxColumn cantidad;
    }
}
