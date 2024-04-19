namespace Actividad2
{
    partial class ModificarCategoria
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
            this.lblSeleccionarCategoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblModificarCategoria = new System.Windows.Forms.Label();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionarCategoria
            // 
            this.lblSeleccionarCategoria.AutoSize = true;
            this.lblSeleccionarCategoria.Location = new System.Drawing.Point(193, 131);
            this.lblSeleccionarCategoria.Name = "lblSeleccionarCategoria";
            this.lblSeleccionarCategoria.Size = new System.Drawing.Size(139, 16);
            this.lblSeleccionarCategoria.TabIndex = 0;
            this.lblSeleccionarCategoria.Text = "Seleccionar categoria";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(386, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // lblModificarCategoria
            // 
            this.lblModificarCategoria.AutoSize = true;
            this.lblModificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarCategoria.Location = new System.Drawing.Point(302, 60);
            this.lblModificarCategoria.Name = "lblModificarCategoria";
            this.lblModificarCategoria.Size = new System.Drawing.Size(184, 22);
            this.lblModificarCategoria.TabIndex = 2;
            this.lblModificarCategoria.Text = "Modificar Categoria";
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(233, 222);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(99, 16);
            this.lblNuevoNombre.TabIndex = 3;
            this.lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 22);
            this.textBox1.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(251, 311);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(141, 48);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(438, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 48);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNuevoNombre);
            this.Controls.Add(this.lblModificarCategoria);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSeleccionarCategoria);
            this.Name = "ModificarCategoria";
            this.Text = "ModificarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionarCategoria;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblModificarCategoria;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}