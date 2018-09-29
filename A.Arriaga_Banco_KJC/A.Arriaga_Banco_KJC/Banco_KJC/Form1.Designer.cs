namespace Banco_KJC
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
            this.tabBanco = new System.Windows.Forms.TabControl();
            this.tabRegistrarCliente = new System.Windows.Forms.TabPage();
            this.txtCorreoElec = new System.Windows.Forms.TextBox();
            this.lblCorreoElec = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtNumExt = new System.Windows.Forms.TextBox();
            this.txtNumInt = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lblNumExt = new System.Windows.Forms.Label();
            this.lblNumInt = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.lblCURP = new System.Windows.Forms.Label();
            this.lblApMat = new System.Windows.Forms.Label();
            this.lblApPat = new System.Windows.Forms.Label();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabAgregarCuenta = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabBanco.SuspendLayout();
            this.tabRegistrarCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBanco
            // 
            this.tabBanco.Controls.Add(this.tabRegistrarCliente);
            this.tabBanco.Controls.Add(this.tabAgregarCuenta);
            this.tabBanco.Location = new System.Drawing.Point(12, 12);
            this.tabBanco.Name = "tabBanco";
            this.tabBanco.SelectedIndex = 0;
            this.tabBanco.ShowToolTips = true;
            this.tabBanco.Size = new System.Drawing.Size(671, 370);
            this.tabBanco.TabIndex = 0;
            // 
            // tabRegistrarCliente
            // 
            this.tabRegistrarCliente.Controls.Add(this.btnGuardar);
            this.tabRegistrarCliente.Controls.Add(this.txtCorreoElec);
            this.tabRegistrarCliente.Controls.Add(this.lblCorreoElec);
            this.tabRegistrarCliente.Controls.Add(this.txtTelefono);
            this.tabRegistrarCliente.Controls.Add(this.lblTelefono);
            this.tabRegistrarCliente.Controls.Add(this.lblDir);
            this.tabRegistrarCliente.Controls.Add(this.panel1);
            this.tabRegistrarCliente.Controls.Add(this.txtCURP);
            this.tabRegistrarCliente.Controls.Add(this.lblCURP);
            this.tabRegistrarCliente.Controls.Add(this.lblApMat);
            this.tabRegistrarCliente.Controls.Add(this.lblApPat);
            this.tabRegistrarCliente.Controls.Add(this.txtApMaterno);
            this.tabRegistrarCliente.Controls.Add(this.txtApPaterno);
            this.tabRegistrarCliente.Controls.Add(this.txtNombre);
            this.tabRegistrarCliente.Controls.Add(this.lblNombre);
            this.tabRegistrarCliente.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrarCliente.Name = "tabRegistrarCliente";
            this.tabRegistrarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrarCliente.Size = new System.Drawing.Size(663, 344);
            this.tabRegistrarCliente.TabIndex = 0;
            this.tabRegistrarCliente.Text = "Registrar cliente";
            this.tabRegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // txtCorreoElec
            // 
            this.txtCorreoElec.AcceptsReturn = true;
            this.txtCorreoElec.Location = new System.Drawing.Point(469, 70);
            this.txtCorreoElec.Name = "txtCorreoElec";
            this.txtCorreoElec.Size = new System.Drawing.Size(160, 20);
            this.txtCorreoElec.TabIndex = 12;
            // 
            // lblCorreoElec
            // 
            this.lblCorreoElec.AutoSize = true;
            this.lblCorreoElec.Location = new System.Drawing.Point(367, 71);
            this.lblCorreoElec.Name = "lblCorreoElec";
            this.lblCorreoElec.Size = new System.Drawing.Size(96, 13);
            this.lblCorreoElec.TabIndex = 11;
            this.lblCorreoElec.Text = "Correo electrónico:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(468, 39);
            this.txtTelefono.MaxLength = 12;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(367, 44);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(34, 152);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(52, 13);
            this.lblDir.TabIndex = 0;
            this.lblDir.Text = "Dirección";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtCP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Controls.Add(this.txtColonia);
            this.panel1.Controls.Add(this.txtNumExt);
            this.panel1.Controls.Add(this.txtNumInt);
            this.panel1.Controls.Add(this.txtCalle);
            this.panel1.Controls.Add(this.lblCiudad);
            this.panel1.Controls.Add(this.lblColonia);
            this.panel1.Controls.Add(this.lblNumExt);
            this.panel1.Controls.Add(this.lblNumInt);
            this.panel1.Controls.Add(this.lblCalle);
            this.panel1.Location = new System.Drawing.Point(37, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 126);
            this.panel1.TabIndex = 8;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(265, 98);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(60, 20);
            this.txtCP.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "C. P.";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(101, 98);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 9;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(101, 69);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(164, 20);
            this.txtColonia.TabIndex = 8;
            // 
            // txtNumExt
            // 
            this.txtNumExt.Location = new System.Drawing.Point(265, 39);
            this.txtNumExt.Name = "txtNumExt";
            this.txtNumExt.Size = new System.Drawing.Size(60, 20);
            this.txtNumExt.TabIndex = 7;
            // 
            // txtNumInt
            // 
            this.txtNumInt.Location = new System.Drawing.Point(101, 39);
            this.txtNumInt.Name = "txtNumInt";
            this.txtNumInt.Size = new System.Drawing.Size(53, 20);
            this.txtNumInt.TabIndex = 6;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(101, 9);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(224, 20);
            this.txtCalle.TabIndex = 5;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(16, 100);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 4;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(14, 69);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(45, 13);
            this.lblColonia.TabIndex = 3;
            this.lblColonia.Text = "Colonia:";
            // 
            // lblNumExt
            // 
            this.lblNumExt.AutoSize = true;
            this.lblNumExt.Location = new System.Drawing.Point(181, 42);
            this.lblNumExt.Name = "lblNumExt";
            this.lblNumExt.Size = new System.Drawing.Size(84, 13);
            this.lblNumExt.TabIndex = 2;
            this.lblNumExt.Text = "Número exterior:";
            // 
            // lblNumInt
            // 
            this.lblNumInt.AutoSize = true;
            this.lblNumInt.Location = new System.Drawing.Point(14, 39);
            this.lblNumInt.Name = "lblNumInt";
            this.lblNumInt.Size = new System.Drawing.Size(81, 13);
            this.lblNumInt.TabIndex = 1;
            this.lblNumInt.Text = "Número interior:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(14, 16);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle:";
            // 
            // txtCURP
            // 
            this.txtCURP.Location = new System.Drawing.Point(122, 126);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(100, 20);
            this.txtCURP.TabIndex = 7;
            this.txtCURP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCURP_KeyPress);
            // 
            // lblCURP
            // 
            this.lblCURP.AutoSize = true;
            this.lblCURP.Location = new System.Drawing.Point(34, 131);
            this.lblCURP.Name = "lblCURP";
            this.lblCURP.Size = new System.Drawing.Size(40, 13);
            this.lblCURP.TabIndex = 6;
            this.lblCURP.Text = "CURP:";
            // 
            // lblApMat
            // 
            this.lblApMat.AutoSize = true;
            this.lblApMat.Location = new System.Drawing.Point(34, 101);
            this.lblApMat.Name = "lblApMat";
            this.lblApMat.Size = new System.Drawing.Size(88, 13);
            this.lblApMat.TabIndex = 5;
            this.lblApMat.Text = "Apellido materno:";
            // 
            // lblApPat
            // 
            this.lblApPat.AutoSize = true;
            this.lblApPat.Location = new System.Drawing.Point(34, 72);
            this.lblApPat.Name = "lblApPat";
            this.lblApPat.Size = new System.Drawing.Size(86, 13);
            this.lblApPat.TabIndex = 4;
            this.lblApPat.Text = "Apellido paterno:";
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(122, 98);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApMaterno.TabIndex = 3;
            this.txtApMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApMaterno_KeyPress);
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(122, 69);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApPaterno.TabIndex = 2;
            this.txtApPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApPaterno_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre (s):";
            // 
            // tabAgregarCuenta
            // 
            this.tabAgregarCuenta.Location = new System.Drawing.Point(4, 22);
            this.tabAgregarCuenta.Name = "tabAgregarCuenta";
            this.tabAgregarCuenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgregarCuenta.Size = new System.Drawing.Size(663, 344);
            this.tabAgregarCuenta.TabIndex = 1;
            this.tabAgregarCuenta.Text = "Agregar cuenta";
            this.tabAgregarCuenta.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(383, 171);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(269, 125);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(695, 394);
            this.Controls.Add(this.tabBanco);
            this.Name = "Form1";
            this.Text = "Banco KJC";
            this.tabBanco.ResumeLayout(false);
            this.tabRegistrarCliente.ResumeLayout(false);
            this.tabRegistrarCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBanco;
        private System.Windows.Forms.TabPage tabRegistrarCliente;
        private System.Windows.Forms.TabPage tabAgregarCuenta;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApMat;
        private System.Windows.Forms.Label lblApPat;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.Label lblCURP;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Label lblNumExt;
        private System.Windows.Forms.Label lblNumInt;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNumInt;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNumExt;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreoElec;
        private System.Windows.Forms.Label lblCorreoElec;
        private System.Windows.Forms.Button btnGuardar;
    }
}

