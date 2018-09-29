namespace DemoColeccionesN
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
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPOP = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnPeek = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.pgbProgreso = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(205, 12);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 0;
            this.btnPush.Text = "PUSH";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPOP
            // 
            this.btnPOP.Location = new System.Drawing.Point(205, 41);
            this.btnPOP.Name = "btnPOP";
            this.btnPOP.Size = new System.Drawing.Size(75, 23);
            this.btnPOP.TabIndex = 1;
            this.btnPOP.Text = "POP";
            this.btnPOP.UseVisualStyleBackColor = true;
            this.btnPOP.Click += new System.EventHandler(this.btnPOP_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(71, 14);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(128, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(21, 17);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero";
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(205, 70);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(75, 22);
            this.btnPeek.TabIndex = 4;
            this.btnPeek.Text = "PEEK";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(23, 44);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(175, 88);
            this.rtbInfo.TabIndex = 5;
            this.rtbInfo.Text = "";
            // 
            // pgbProgreso
            // 
            this.pgbProgreso.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pgbProgreso.ForeColor = System.Drawing.Color.Lime;
            this.pgbProgreso.Location = new System.Drawing.Point(205, 108);
            this.pgbProgreso.Name = "pgbProgreso";
            this.pgbProgreso.Size = new System.Drawing.Size(75, 23);
            this.pgbProgreso.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 150);
            this.Controls.Add(this.pgbProgreso);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnPOP);
            this.Controls.Add(this.btnPush);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPOP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.ProgressBar pgbProgreso;
    }
}

