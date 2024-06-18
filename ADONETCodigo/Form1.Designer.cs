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
            this.btnDemo2 = new System.Windows.Forms.Button();
            this.btnDemo3 = new System.Windows.Forms.Button();
            this.btnUsing = new System.Windows.Forms.Button();
            this.btnDemoDR = new System.Windows.Forms.Button();
            this.ClinicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClinicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDemo
            // 
            this.btnDemo.Location = new System.Drawing.Point(35, 59);
            this.btnDemo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(107, 39);
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
            this.ClinicName,
            this.Cantidad});
            this.dgvDemo.Location = new System.Drawing.Point(35, 137);
            this.dgvDemo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDemo.Name = "dgvDemo";
            this.dgvDemo.RowHeadersWidth = 51;
            this.dgvDemo.RowTemplate.Height = 24;
            this.dgvDemo.Size = new System.Drawing.Size(551, 122);
            this.dgvDemo.TabIndex = 1;
            // 
            // btnDemo2
            // 
            this.btnDemo2.Location = new System.Drawing.Point(146, 59);
            this.btnDemo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDemo2.Name = "btnDemo2";
            this.btnDemo2.Size = new System.Drawing.Size(107, 39);
            this.btnDemo2.TabIndex = 2;
            this.btnDemo2.Text = "Listar2";
            this.btnDemo2.UseVisualStyleBackColor = true;
            this.btnDemo2.Click += new System.EventHandler(this.btnDemo2_Click);
            // 
            // btnDemo3
            // 
            this.btnDemo3.Location = new System.Drawing.Point(368, 59);
            this.btnDemo3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDemo3.Name = "btnDemo3";
            this.btnDemo3.Size = new System.Drawing.Size(107, 39);
            this.btnDemo3.TabIndex = 3;
            this.btnDemo3.Text = "ListarDT";
            this.btnDemo3.UseVisualStyleBackColor = true;
            this.btnDemo3.Click += new System.EventHandler(this.btnDemo3_Click);
            // 
            // btnUsing
            // 
            this.btnUsing.Location = new System.Drawing.Point(257, 59);
            this.btnUsing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsing.Name = "btnUsing";
            this.btnUsing.Size = new System.Drawing.Size(107, 39);
            this.btnUsing.TabIndex = 4;
            this.btnUsing.Text = "Listar Using";
            this.btnUsing.UseVisualStyleBackColor = true;
            this.btnUsing.Click += new System.EventHandler(this.btnUsing_Click);
            // 
            // btnDemoDR
            // 
            this.btnDemoDR.Location = new System.Drawing.Point(479, 59);
            this.btnDemoDR.Margin = new System.Windows.Forms.Padding(2);
            this.btnDemoDR.Name = "btnDemoDR";
            this.btnDemoDR.Size = new System.Drawing.Size(107, 39);
            this.btnDemoDR.TabIndex = 5;
            this.btnDemoDR.Text = "Listar DR";
            this.btnDemoDR.UseVisualStyleBackColor = true;
            this.btnDemoDR.Click += new System.EventHandler(this.btnDemoDR_Click);
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
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 366);
            this.Controls.Add(this.btnDemoDR);
            this.Controls.Add(this.btnUsing);
            this.Controls.Add(this.btnDemo3);
            this.Controls.Add(this.btnDemo2);
            this.Controls.Add(this.dgvDemo);
            this.Controls.Add(this.btnDemo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.DataGridView dgvDemo;
        private System.Windows.Forms.Button btnDemo2;
        private System.Windows.Forms.Button btnDemo3;
        private System.Windows.Forms.Button btnUsing;
        private System.Windows.Forms.Button btnDemoDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClinicID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClinicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}

