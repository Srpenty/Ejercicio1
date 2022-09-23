
namespace Practica16septiembre2022
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
            this.txtMensaje1 = new System.Windows.Forms.TextBox();
            this.btnMensaje1 = new System.Windows.Forms.Button();
            this.btnMensje2 = new System.Windows.Forms.Button();
            this.txtMensaje2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMensaje1
            // 
            this.txtMensaje1.Location = new System.Drawing.Point(83, 12);
            this.txtMensaje1.Name = "txtMensaje1";
            this.txtMensaje1.Size = new System.Drawing.Size(231, 22);
            this.txtMensaje1.TabIndex = 0;
            this.txtMensaje1.TextChanged += new System.EventHandler(this.txtMensaje1_TextChanged);
            // 
            // btnMensaje1
            // 
            this.btnMensaje1.Location = new System.Drawing.Point(83, 66);
            this.btnMensaje1.Name = "btnMensaje1";
            this.btnMensaje1.Size = new System.Drawing.Size(231, 23);
            this.btnMensaje1.TabIndex = 1;
            this.btnMensaje1.Text = "Enviar Mensaje 1";
            this.btnMensaje1.UseVisualStyleBackColor = true;
            this.btnMensaje1.Click += new System.EventHandler(this.btnMensaje1_Click);
            // 
            // btnMensje2
            // 
            this.btnMensje2.Location = new System.Drawing.Point(365, 66);
            this.btnMensje2.Name = "btnMensje2";
            this.btnMensje2.Size = new System.Drawing.Size(231, 23);
            this.btnMensje2.TabIndex = 3;
            this.btnMensje2.Text = "Enviar Mensaje 2";
            this.btnMensje2.UseVisualStyleBackColor = true;
            this.btnMensje2.Click += new System.EventHandler(this.btnMensje2_Click);
            // 
            // txtMensaje2
            // 
            this.txtMensaje2.Location = new System.Drawing.Point(365, 12);
            this.txtMensaje2.Name = "txtMensaje2";
            this.txtMensaje2.Size = new System.Drawing.Size(231, 22);
            this.txtMensaje2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 193);
            this.Controls.Add(this.btnMensje2);
            this.Controls.Add(this.txtMensaje2);
            this.Controls.Add(this.btnMensaje1);
            this.Controls.Add(this.txtMensaje1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje1;
        private System.Windows.Forms.Button btnMensaje1;
        private System.Windows.Forms.Button btnMensje2;
        private System.Windows.Forms.TextBox txtMensaje2;
    }
}

