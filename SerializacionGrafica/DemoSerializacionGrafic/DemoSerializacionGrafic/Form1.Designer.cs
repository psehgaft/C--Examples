namespace DemoSerializacionGrafic
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.bntSerializar = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bntSerializar
            // 
            this.bntSerializar.Location = new System.Drawing.Point(264, 18);
            this.bntSerializar.Name = "bntSerializar";
            this.bntSerializar.Size = new System.Drawing.Size(91, 32);
            this.bntSerializar.TabIndex = 0;
            this.bntSerializar.Text = "&Serializar";
            this.bntSerializar.UseVisualStyleBackColor = true;
            this.bntSerializar.Click += new System.EventHandler(this.bntSerializar_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(34, 68);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(321, 240);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 338);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.bntSerializar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntSerializar;
        private System.Windows.Forms.RichTextBox rtbInfo;
    }
}

