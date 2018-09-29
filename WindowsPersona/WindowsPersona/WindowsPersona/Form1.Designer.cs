namespace WindowsPersona
{
    partial class Form1
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblapPaterno = new System.Windows.Forms.Label();
            this.lblapMat = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtapPat = new System.Windows.Forms.TextBox();
            this.txtapMat = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.picCarita = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCarita)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(25, 304);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 47);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblapPaterno
            // 
            this.lblapPaterno.AutoSize = true;
            this.lblapPaterno.Location = new System.Drawing.Point(22, 46);
            this.lblapPaterno.Name = "lblapPaterno";
            this.lblapPaterno.Size = new System.Drawing.Size(84, 13);
            this.lblapPaterno.TabIndex = 2;
            this.lblapPaterno.Text = "Apellido Paterno";
            // 
            // lblapMat
            // 
            this.lblapMat.AutoSize = true;
            this.lblapMat.Location = new System.Drawing.Point(22, 74);
            this.lblapMat.Name = "lblapMat";
            this.lblapMat.Size = new System.Drawing.Size(89, 13);
            this.lblapMat.TabIndex = 3;
            this.lblapMat.Text = "Apellido Materno:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(22, 102);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad: ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(22, 130);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(22, 158);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(122, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtapPat
            // 
            this.txtapPat.Location = new System.Drawing.Point(129, 43);
            this.txtapPat.Name = "txtapPat";
            this.txtapPat.Size = new System.Drawing.Size(122, 20);
            this.txtapPat.TabIndex = 8;
            // 
            // txtapMat
            // 
            this.txtapMat.Location = new System.Drawing.Point(129, 71);
            this.txtapMat.Name = "txtapMat";
            this.txtapMat.Size = new System.Drawing.Size(122, 20);
            this.txtapMat.TabIndex = 9;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(129, 99);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(122, 20);
            this.txtEdad.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(129, 127);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(122, 20);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(129, 155);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(122, 20);
            this.txtDireccion.TabIndex = 12;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(149, 306);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(101, 44);
            this.btnMostrar.TabIndex = 13;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // picCarita
            // 
            this.picCarita.Image = global::WindowsPersona.Properties.Resources.feliz;
            this.picCarita.Location = new System.Drawing.Point(26, 188);
            this.picCarita.Name = "picCarita";
            this.picCarita.Size = new System.Drawing.Size(223, 98);
            this.picCarita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarita.TabIndex = 14;
            this.picCarita.TabStop = false;
            this.picCarita.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 363);
            this.Controls.Add(this.picCarita);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtapMat);
            this.Controls.Add(this.txtapPat);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblapMat);
            this.Controls.Add(this.lblapPaterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCarita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblapPaterno;
        private System.Windows.Forms.Label lblapMat;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtapPat;
        private System.Windows.Forms.TextBox txtapMat;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.PictureBox picCarita;
    }
}

