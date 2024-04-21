namespace Actividad2
{
    partial class frmListadoArt
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgbArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARTICULOS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(560, 59);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(169, 38);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgbArticulos
            // 
            this.dgbArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbArticulos.Location = new System.Drawing.Point(1, 50);
            this.dgbArticulos.Name = "dgbArticulos";
            this.dgbArticulos.Size = new System.Drawing.Size(537, 285);
            this.dgbArticulos.TabIndex = 4;
            // 
            // frmListadoArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgbArticulos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Name = "frmListadoArt";
            this.Text = "frmListadoArt";
            this.Load += new System.EventHandler(this.frmListadoArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgbArticulos;
    }
}