namespace ArrastrarSoltarCeldasDgv
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv1Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv2Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv1Nombre});
            this.dgv1.Location = new System.Drawing.Point(26, 110);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(335, 222);
            this.dgv1.TabIndex = 0;
            // 
            // dgv1Nombre
            // 
            this.dgv1Nombre.HeaderText = "Nombre";
            this.dgv1Nombre.MinimumWidth = 8;
            this.dgv1Nombre.Name = "dgv1Nombre";
            this.dgv1Nombre.Width = 150;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv2Nombre});
            this.dgv2.Location = new System.Drawing.Point(432, 110);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 62;
            this.dgv2.RowTemplate.Height = 28;
            this.dgv2.Size = new System.Drawing.Size(345, 222);
            this.dgv2.TabIndex = 1;
            this.dgv2.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv2_CellMouseDown);
            this.dgv2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgv2_DragDrop);
            this.dgv2.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgv2_DragEnter);
            // 
            // dgv2Nombre
            // 
            this.dgv2Nombre.HeaderText = "Nombre";
            this.dgv2Nombre.MinimumWidth = 8;
            this.dgv2Nombre.Name = "dgv2Nombre";
            this.dgv2Nombre.Width = 150;
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.Location = new System.Drawing.Point(183, 52);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(443, 32);
            this.lbTexto.TabIndex = 2;
            this.lbTexto.Text = "Arrastrar un celda de uno a otro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTexto);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv1Nombre;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv2Nombre;
        private System.Windows.Forms.Label lbTexto;
    }
}

