
namespace DebeAbrirCarpetasyLeer
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCargar = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.listAbrirCarpetas = new System.Windows.Forms.ListBox();
            this.listAbrirArchivos = new System.Windows.Forms.ListBox();
            this.listAbrirSubTextos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abrir Carpetas";
            // 
            // textCargar
            // 
            this.textCargar.Location = new System.Drawing.Point(21, 58);
            this.textCargar.Name = "textCargar";
            this.textCargar.Size = new System.Drawing.Size(312, 20);
            this.textCargar.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(401, 26);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(85, 51);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // listAbrirCarpetas
            // 
            this.listAbrirCarpetas.FormattingEnabled = true;
            this.listAbrirCarpetas.Location = new System.Drawing.Point(21, 107);
            this.listAbrirCarpetas.Name = "listAbrirCarpetas";
            this.listAbrirCarpetas.Size = new System.Drawing.Size(166, 173);
            this.listAbrirCarpetas.TabIndex = 3;
            this.listAbrirCarpetas.SelectedIndexChanged += new System.EventHandler(this.listAbrirCarpetas_SelectedIndexChanged);
            // 
            // listAbrirArchivos
            // 
            this.listAbrirArchivos.FormattingEnabled = true;
            this.listAbrirArchivos.Location = new System.Drawing.Point(244, 107);
            this.listAbrirArchivos.Name = "listAbrirArchivos";
            this.listAbrirArchivos.Size = new System.Drawing.Size(172, 173);
            this.listAbrirArchivos.TabIndex = 4;
            this.listAbrirArchivos.SelectedIndexChanged += new System.EventHandler(this.listAbrirArchivos_SelectedIndexChanged);
            // 
            // listAbrirSubTextos
            // 
            this.listAbrirSubTextos.FormattingEnabled = true;
            this.listAbrirSubTextos.Location = new System.Drawing.Point(496, 105);
            this.listAbrirSubTextos.Name = "listAbrirSubTextos";
            this.listAbrirSubTextos.Size = new System.Drawing.Size(167, 173);
            this.listAbrirSubTextos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listAbrirSubTextos);
            this.Controls.Add(this.listAbrirArchivos);
            this.Controls.Add(this.listAbrirCarpetas);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.textCargar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCargar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox listAbrirCarpetas;
        private System.Windows.Forms.ListBox listAbrirArchivos;
        private System.Windows.Forms.ListBox listAbrirSubTextos;
    }
}

