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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle86 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle87 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle88 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle89 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle90 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgbArticulos = new System.Windows.Forms.DataGridView();
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listado de articulos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(746, 25);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(197, 45);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseCompatibleTextRendering = true;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgbArticulos
            // 
            dataGridViewCellStyle86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle86.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle86.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle86.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle86.SelectionForeColor = System.Drawing.Color.White;
            this.dgbArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle86;
            this.dgbArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgbArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgbArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle87.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle87.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle87.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle87.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle87.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle87.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle87.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle87;
            this.dgbArticulos.ColumnHeadersHeight = 30;
            this.dgbArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle88.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle88.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle88.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle88.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle88.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle88.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbArticulos.DefaultCellStyle = dataGridViewCellStyle88;
            this.dgbArticulos.EnableHeadersVisualStyles = false;
            this.dgbArticulos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgbArticulos.Location = new System.Drawing.Point(22, 50);
            this.dgbArticulos.Name = "dgbArticulos";
            this.dgbArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle89.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle89.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle89.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle89.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle89.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle89.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle89;
            this.dgbArticulos.RowHeadersVisible = false;
            dataGridViewCellStyle90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle90.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle90.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle90.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle90.SelectionForeColor = System.Drawing.Color.White;
            this.dgbArticulos.RowsDefaultCellStyle = dataGridViewCellStyle90;
            this.dgbArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbArticulos.Size = new System.Drawing.Size(685, 320);
            this.dgbArticulos.TabIndex = 4;
            this.dgbArticulos.SelectionChanged += new System.EventHandler(this.dgbArticulos_SelectionChanged);
            // 
            // pbArticulos
            // 
            this.pbArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbArticulos.Location = new System.Drawing.Point(713, 87);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(258, 243);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 5;
            this.pbArticulos.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Editar";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(147, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmListadoArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1004, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbArticulos);
            this.Controls.Add(this.dgbArticulos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.DataGridView dgbArticulos;
        private System.Windows.Forms.PictureBox pbArticulos;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}