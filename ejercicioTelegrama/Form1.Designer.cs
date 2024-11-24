namespace ejercicioTelegrama
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
            this.labelTexto = new System.Windows.Forms.Label();
            this.txtBoxTexto = new System.Windows.Forms.TextBox();
            this.checkBoxUrgente = new System.Windows.Forms.CheckBox();
            this.labelCoste = new System.Windows.Forms.Label();
            this.txtBoxCoste = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.Location = new System.Drawing.Point(74, 59);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(39, 13);
            this.labelTexto.TabIndex = 0;
            this.labelTexto.Text = "Texto";
            // 
            // txtBoxTexto
            // 
            this.txtBoxTexto.Location = new System.Drawing.Point(77, 84);
            this.txtBoxTexto.Multiline = true;
            this.txtBoxTexto.Name = "txtBoxTexto";
            this.txtBoxTexto.Size = new System.Drawing.Size(414, 131);
            this.txtBoxTexto.TabIndex = 1;
            // 
            // checkBoxUrgente
            // 
            this.checkBoxUrgente.AutoSize = true;
            this.checkBoxUrgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUrgente.Location = new System.Drawing.Point(77, 247);
            this.checkBoxUrgente.Name = "checkBoxUrgente";
            this.checkBoxUrgente.Size = new System.Drawing.Size(85, 17);
            this.checkBoxUrgente.TabIndex = 2;
            this.checkBoxUrgente.Text = "¿Urgente?";
            this.checkBoxUrgente.UseVisualStyleBackColor = true;
            // 
            // labelCoste
            // 
            this.labelCoste.AutoSize = true;
            this.labelCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoste.Location = new System.Drawing.Point(74, 309);
            this.labelCoste.Name = "labelCoste";
            this.labelCoste.Size = new System.Drawing.Size(43, 13);
            this.labelCoste.TabIndex = 3;
            this.labelCoste.Text = "Coste:";
            // 
            // txtBoxCoste
            // 
            this.txtBoxCoste.Location = new System.Drawing.Point(128, 306);
            this.txtBoxCoste.Name = "txtBoxCoste";
            this.txtBoxCoste.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCoste.TabIndex = 4;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(374, 277);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(100, 49);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 430);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtBoxCoste);
            this.Controls.Add(this.labelCoste);
            this.Controls.Add(this.checkBoxUrgente);
            this.Controls.Add(this.txtBoxTexto);
            this.Controls.Add(this.labelTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.TextBox txtBoxTexto;
        private System.Windows.Forms.CheckBox checkBoxUrgente;
        private System.Windows.Forms.Label labelCoste;
        private System.Windows.Forms.TextBox txtBoxCoste;
        private System.Windows.Forms.Button BtnCalcular;
    }
}

