namespace Actividad2
{
    partial class agregarMarca_categoria
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
            this.txtMarc = new System.Windows.Forms.TextBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarCarc = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnModMarc = new System.Windows.Forms.Button();
            this.btnModCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca nueva:";
            // 
            // txtMarc
            // 
            this.txtMarc.Location = new System.Drawing.Point(93, 43);
            this.txtMarc.Name = "txtMarc";
            this.txtMarc.Size = new System.Drawing.Size(100, 20);
            this.txtMarc.TabIndex = 1;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(218, 39);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 2;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(218, 93);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 5;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(93, 97);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(100, 20);
            this.txtCat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria nueva:";
            // 
            // btnEliminarCarc
            // 
            this.btnEliminarCarc.Location = new System.Drawing.Point(316, 39);
            this.btnEliminarCarc.Name = "btnEliminarCarc";
            this.btnEliminarCarc.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCarc.TabIndex = 6;
            this.btnEliminarCarc.Text = "Eliminar";
            this.btnEliminarCarc.UseVisualStyleBackColor = true;
            this.btnEliminarCarc.Click += new System.EventHandler(this.btnEliminarCarc_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(316, 95);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCat.TabIndex = 7;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // btnModMarc
            // 
            this.btnModMarc.Location = new System.Drawing.Point(410, 40);
            this.btnModMarc.Name = "btnModMarc";
            this.btnModMarc.Size = new System.Drawing.Size(75, 23);
            this.btnModMarc.TabIndex = 8;
            this.btnModMarc.Text = "Modificar";
            this.btnModMarc.UseVisualStyleBackColor = true;
            this.btnModMarc.Click += new System.EventHandler(this.btnModMarc_Click);
            // 
            // btnModCat
            // 
            this.btnModCat.Location = new System.Drawing.Point(410, 95);
            this.btnModCat.Name = "btnModCat";
            this.btnModCat.Size = new System.Drawing.Size(75, 23);
            this.btnModCat.TabIndex = 9;
            this.btnModCat.Text = "Modificar";
            this.btnModCat.UseVisualStyleBackColor = true;
            this.btnModCat.Click += new System.EventHandler(this.btnModCat_Click);
            // 
            // agregarMarca_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 274);
            this.Controls.Add(this.btnModCat);
            this.Controls.Add(this.btnModMarc);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.btnEliminarCarc);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.txtMarc);
            this.Controls.Add(this.label1);
            this.Name = "agregarMarca_categoria";
            this.Text = "agregarMarca_categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarc;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarCarc;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnModMarc;
        private System.Windows.Forms.Button btnModCat;
    }
}