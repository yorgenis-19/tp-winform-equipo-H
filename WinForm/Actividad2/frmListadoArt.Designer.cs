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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgbArticulos = new System.Windows.Forms.DataGridView();
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgbArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "ARTICULOS";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(587, 69);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(169, 38);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgbArticulos
            // 
            this.dgbArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbArticulos.Location = new System.Drawing.Point(1, 50);
            this.dgbArticulos.Name = "dgbArticulos";
            this.dgbArticulos.Size = new System.Drawing.Size(553, 388);
            this.dgbArticulos.TabIndex = 4;
            this.dgbArticulos.SelectionChanged += new System.EventHandler(this.dgbArticulos_SelectionChanged);
            // 
            // pbArticulos
            // 
            this.pbArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbArticulos.Location = new System.Drawing.Point(560, 113);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(228, 243);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 5;
            this.pbArticulos.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmListadoArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbArticulos);
            this.Controls.Add(this.dgbArticulos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Name = "frmListadoArt";
            this.Text = "frmListadoArt";
            this.Load += new System.EventHandler(this.frmListadoArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgbArticulos;
        private System.Windows.Forms.PictureBox pbArticulos;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}