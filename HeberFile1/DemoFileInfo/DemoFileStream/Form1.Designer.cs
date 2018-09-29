namespace DemoFileStream
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
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.rtbbox = new System.Windows.Forms.RichTextBox();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(31, 29);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Items.AddRange(new object[] {
            "-Seleccione operacion",
            "Abrir achivo",
            "Escribir archivo"});
            this.cmbOperacion.Location = new System.Drawing.Point(128, 31);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(239, 21);
            this.cmbOperacion.TabIndex = 1;
            // 
            // rtbbox
            // 
            this.rtbbox.Location = new System.Drawing.Point(56, 87);
            this.rtbbox.Name = "rtbbox";
            this.rtbbox.Size = new System.Drawing.Size(311, 206);
            this.rtbbox.TabIndex = 2;
            this.rtbbox.Text = "";
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.FileName = "openFileDialog1";
            this.ofdAbrir.Title = "d";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 362);
            this.Controls.Add(this.rtbbox);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.btnEjecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.RichTextBox rtbbox;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
    }
}

