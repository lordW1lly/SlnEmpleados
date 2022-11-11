namespace PresentacionWindows
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnCargarDpto = new System.Windows.Forms.Button();
            this.bttnVerEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bttnCargarDpto
            // 
            this.bttnCargarDpto.Location = new System.Drawing.Point(30, 321);
            this.bttnCargarDpto.Name = "bttnCargarDpto";
            this.bttnCargarDpto.Size = new System.Drawing.Size(117, 45);
            this.bttnCargarDpto.TabIndex = 1;
            this.bttnCargarDpto.Text = "Cargar Departamento";
            this.bttnCargarDpto.UseVisualStyleBackColor = true;
            this.bttnCargarDpto.Click += new System.EventHandler(this.bttnCargarDpto_Click);
            // 
            // bttnVerEmpleados
            // 
            this.bttnVerEmpleados.Location = new System.Drawing.Point(224, 321);
            this.bttnVerEmpleados.Name = "bttnVerEmpleados";
            this.bttnVerEmpleados.Size = new System.Drawing.Size(122, 45);
            this.bttnVerEmpleados.TabIndex = 2;
            this.bttnVerEmpleados.Text = "Ver Empleados";
            this.bttnVerEmpleados.UseVisualStyleBackColor = true;
            this.bttnVerEmpleados.Click += new System.EventHandler(this.bttnVerEmpleados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnVerEmpleados);
            this.Controls.Add(this.bttnCargarDpto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnCargarDpto;
        private System.Windows.Forms.Button bttnVerEmpleados;
    }
}

