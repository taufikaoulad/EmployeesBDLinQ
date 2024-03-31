namespace EmployeesBDLinQ
{
    partial class FormEmployees
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
            this.label10 = new System.Windows.Forms.Label();
            this.BtnDelate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listEmployees = new System.Windows.Forms.ListBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 37.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(92, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 76);
            this.label10.TabIndex = 41;
            this.label10.Text = "Employees";
            // 
            // BtnDelate
            // 
            this.BtnDelate.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDelate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelate.ForeColor = System.Drawing.Color.White;
            this.BtnDelate.Location = new System.Drawing.Point(254, 475);
            this.BtnDelate.Name = "BtnDelate";
            this.BtnDelate.Size = new System.Drawing.Size(128, 45);
            this.BtnDelate.TabIndex = 47;
            this.BtnDelate.Text = "Delete";
            this.BtnDelate.UseVisualStyleBackColor = false;
            this.BtnDelate.Click += new System.EventHandler(this.BtnDelate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(105, 475);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 45);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listEmployees
            // 
            this.listEmployees.BackColor = System.Drawing.Color.Azure;
            this.listEmployees.FormattingEnabled = true;
            this.listEmployees.ItemHeight = 16;
            this.listEmployees.Location = new System.Drawing.Point(105, 152);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(277, 292);
            this.listEmployees.TabIndex = 51;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Teal;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(105, 547);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(277, 48);
            this.btnInsert.TabIndex = 52;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(506, 627);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.listEmployees);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.BtnDelate);
            this.Controls.Add(this.label10);
            this.Name = "FormEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnDelate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox listEmployees;
        private System.Windows.Forms.Button btnInsert;
    }
}

