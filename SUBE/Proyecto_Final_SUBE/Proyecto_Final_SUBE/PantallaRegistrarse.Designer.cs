namespace Proyecto_Final_SUBE
{
    partial class PantallaRegistrarse
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
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            botonCircular1 = new RoundedCircle.BotonCircular();
            lblTituloRegistrarse = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(262, 287);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(262, 344);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(155, 27);
            txtContraseña.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(261, 139);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(155, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(262, 188);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(155, 27);
            txtApellido.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(262, 236);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(155, 27);
            txtDni.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(69, 292);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(210, 17);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Ingrese nombre de usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(109, 349);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(162, 17);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Ingrese Contraseña: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(112, 144);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(147, 17);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Ingrese su Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(119, 193);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(148, 17);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Ingrese su Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(123, 241);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(125, 17);
            lblDni.TabIndex = 9;
            lblDni.Text = "Ingrese su DNI: ";
            // 
            // botonCircular1
            // 
            botonCircular1.BackColor = Color.DarkGray;
            botonCircular1.BackgroundColor = Color.DarkGray;
            botonCircular1.BorderColor = Color.PaleVioletRed;
            botonCircular1.BorderRadius = 40;
            botonCircular1.BorderSize = 0;
            botonCircular1.FlatAppearance.BorderSize = 0;
            botonCircular1.FlatStyle = FlatStyle.Flat;
            botonCircular1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            botonCircular1.ForeColor = Color.White;
            botonCircular1.Location = new Point(213, 425);
            botonCircular1.Margin = new Padding(3, 4, 3, 4);
            botonCircular1.Name = "botonCircular1";
            botonCircular1.Size = new Size(205, 53);
            botonCircular1.TabIndex = 10;
            botonCircular1.Text = "REGISTRARSE";
            botonCircular1.TextColor = Color.White;
            botonCircular1.UseVisualStyleBackColor = false;
            botonCircular1.Click += botonCircular1_Click;
            // 
            // lblTituloRegistrarse
            // 
            lblTituloRegistrarse.AutoSize = true;
            lblTituloRegistrarse.Font = new Font("Arial Rounded MT Bold", 39.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblTituloRegistrarse.Location = new Point(45, 12);
            lblTituloRegistrarse.Name = "lblTituloRegistrarse";
            lblTituloRegistrarse.Size = new Size(638, 77);
            lblTituloRegistrarse.TabIndex = 11;
            lblTituloRegistrarse.Text = "CREÁ TU CUENTA";
            // 
            // PantallaRegistrarse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(631, 620);
            Controls.Add(lblTituloRegistrarse);
            Controls.Add(botonCircular1);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaRegistrarse";
            Text = "PantallaRegistrarse";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private RoundedCircle.BotonCircular botonCircular1;
        private Label lblTituloRegistrarse;
    }
}