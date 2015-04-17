namespace combobox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxrojo = new System.Windows.Forms.ComboBox();
            this.cbxverde = new System.Windows.Forms.ComboBox();
            this.cbxazul = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxrojo
            // 
            this.cbxrojo.FormattingEnabled = true;
            this.cbxrojo.Location = new System.Drawing.Point(117, 12);
            this.cbxrojo.Name = "cbxrojo";
            this.cbxrojo.Size = new System.Drawing.Size(121, 21);
            this.cbxrojo.TabIndex = 0;
            // 
            // cbxverde
            // 
            this.cbxverde.FormattingEnabled = true;
            this.cbxverde.Location = new System.Drawing.Point(117, 40);
            this.cbxverde.Name = "cbxverde";
            this.cbxverde.Size = new System.Drawing.Size(121, 21);
            this.cbxverde.TabIndex = 1;
            // 
            // cbxazul
            // 
            this.cbxazul.FormattingEnabled = true;
            this.cbxazul.Location = new System.Drawing.Point(117, 68);
            this.cbxazul.Name = "cbxazul";
            this.cbxazul.Size = new System.Drawing.Size(121, 21);
            this.cbxazul.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Verde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Azul";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(68, 105);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(102, 23);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "Colorear Fondo";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 136);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxazul);
            this.Controls.Add(this.cbxverde);
            this.Controls.Add(this.cbxrojo);
            this.Name = "Form1";
            this.Text = "Colorear";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxrojo;
        private System.Windows.Forms.ComboBox cbxverde;
        private System.Windows.Forms.ComboBox cbxazul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnaceptar;
    }
}

