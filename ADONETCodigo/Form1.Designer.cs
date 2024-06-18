namespace ADONETCodigo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDemo = new System.Windows.Forms.Button();
            this.dgvDemo = new System.Windows.Forms.DataGridView();
            this.ClinicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClinicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDemo2 = new System.Windows.Forms.Button();
            this.btnDemo3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(47, 73);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(143, 48);
            this.btnDemo.TabIndex = 0;
            this.btnDemo.Text = "Listar";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // dgvDemo
            // 
            this.dgvDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClinicID,
            this.ClinicName});
            this.dgvDemo.Location = new System.Drawing.Point(47, 169);
            this.dgvDemo.Name = "dgvDemo";
            this.dgvDemo.RowHeadersWidth = 51;
            this.dgvDemo.RowTemplate.Height = 24;
            this.dgvDemo.Size = new System.Drawing.Size(655, 150);
            this.dgvDemo.TabIndex = 1;
            // 
            // ClinicID
            // 
            this.ClinicID.DataPropertyName = "ClinicID";
            this.ClinicID.HeaderText = "ClinicID";
            this.ClinicID.MinimumWidth = 6;
            this.ClinicID.Name = "ClinicID";
            this.ClinicID.Width = 125;
            // 
            // ClinicName
            // 
            this.ClinicName.DataPropertyName = "ClinicName";
            this.ClinicName.HeaderText = "ClinicName";
            this.ClinicName.MinimumWidth = 6;
            this.ClinicName.Name = "ClinicName";
            this.ClinicName.Width = 125;
            // 
            // btnDemo2
            // 
            this.btnDemo2.Location = new System.Drawing.Point(225, 73);
            this.btnDemo2.Name = "btnDemo2";
            this.btnDemo2.Size = new System.Drawing.Size(143, 48);
            this.btnDemo2.TabIndex = 2;
            this.btnDemo2.Text = "Listar2";
            this.btnDemo2.UseVisualStyleBackColor = true;
            this.btnDemo2.Click += new System.EventHandler(this.btnDemo2_Click);
            // 
            // btnDemo3
            // 
            this.btnDemo3.Location = new System.Drawing.Point(390, 73);
            this.btnDemo3.Name = "btnDemo3";
            this.btnDemo3.Size = new System.Drawing.Size(143, 48);
            this.btnDemo3.TabIndex = 3;
            this.btnDemo3.Text = "Listar3";
            this.btnDemo3.UseVisualStyleBackColor = true;
            this.btnDemo3.Click += new System.EventHandler(this.btnDemo3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDemo3);
            this.Controls.Add(this.btnDemo2);
            this.Controls.Add(this.dgvDemo);
            this.Controls.Add(this.btnDemo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.DataGridView dgvDemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClinicID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClinicName;
        private System.Windows.Forms.Button btnDemo2;
        private System.Windows.Forms.Button btnDemo3;
    }
}

