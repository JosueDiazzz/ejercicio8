namespace ejercicio1
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
            this.mensaje1 = new System.Windows.Forms.Button();
            this.txtMensaje1 = new System.Windows.Forms.TextBox();
            this.txtMensaje2 = new System.Windows.Forms.TextBox();
            this.btnMensaje2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mensaje1
            // 
            this.mensaje1.Location = new System.Drawing.Point(24, 12);
            this.mensaje1.Name = "mensaje1";
            this.mensaje1.Size = new System.Drawing.Size(158, 23);
            this.mensaje1.TabIndex = 0;
            this.mensaje1.Text = "Enviar Mensaje 1";
            this.mensaje1.UseVisualStyleBackColor = true;
            this.mensaje1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMensaje1
            // 
            this.txtMensaje1.Location = new System.Drawing.Point(24, 58);
            this.txtMensaje1.Name = "txtMensaje1";
            this.txtMensaje1.Size = new System.Drawing.Size(158, 20);
            this.txtMensaje1.TabIndex = 1;
            // 
            // txtMensaje2
            // 
            this.txtMensaje2.Location = new System.Drawing.Point(247, 58);
            this.txtMensaje2.Name = "txtMensaje2";
            this.txtMensaje2.Size = new System.Drawing.Size(158, 20);
            this.txtMensaje2.TabIndex = 3;
            this.txtMensaje2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMensaje2
            // 
            this.btnMensaje2.Location = new System.Drawing.Point(247, 12);
            this.btnMensaje2.Name = "btnMensaje2";
            this.btnMensaje2.Size = new System.Drawing.Size(158, 23);
            this.btnMensaje2.TabIndex = 2;
            this.btnMensaje2.Text = "Enviar Mensaje 2";
            this.btnMensaje2.UseVisualStyleBackColor = true;
            this.btnMensaje2.Click += new System.EventHandler(this.btnMensaje2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 111);
            this.Controls.Add(this.txtMensaje2);
            this.Controls.Add(this.btnMensaje2);
            this.Controls.Add(this.txtMensaje1);
            this.Controls.Add(this.mensaje1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mensaje1;
        private System.Windows.Forms.TextBox txtMensaje1;
        private System.Windows.Forms.TextBox txtMensaje2;
        private System.Windows.Forms.Button btnMensaje2;
    }
}

