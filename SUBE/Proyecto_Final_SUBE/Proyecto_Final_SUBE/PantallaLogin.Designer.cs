namespace WindowsFormsApp1
{
    partial class PantallaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaLogin));
            txt_User = new TextBox();
            txt_password = new TextBox();
            lbl_Bienvenido = new Label();
            lbl_Usuario = new Label();
            lbl_Contraseña = new Label();
            btn_Iniciar = new Button();
            pic_Fondo = new PictureBox();
            link_Registracion = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pic_Fondo).BeginInit();
            SuspendLayout();
            // 
            // txt_User
            // 
            txt_User.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_User.ForeColor = SystemColors.InfoText;
            txt_User.Location = new Point(615, 349);
            txt_User.Margin = new Padding(5, 4, 5, 4);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(259, 26);
            txt_User.TabIndex = 0;
            txt_User.TextChanged += txt_User_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.Window;
            txt_password.Location = new Point(615, 416);
            txt_password.Margin = new Padding(5, 4, 5, 4);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(259, 27);
            txt_password.TabIndex = 1;
            txt_password.Tag = "";
            // 
            // lbl_Bienvenido
            // 
            lbl_Bienvenido.AutoSize = true;
            lbl_Bienvenido.BackColor = Color.Transparent;
            lbl_Bienvenido.FlatStyle = FlatStyle.Flat;
            lbl_Bienvenido.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Bienvenido.ForeColor = SystemColors.ControlLightLight;
            lbl_Bienvenido.Location = new Point(632, 131);
            lbl_Bienvenido.Margin = new Padding(5, 0, 5, 0);
            lbl_Bienvenido.Name = "lbl_Bienvenido";
            lbl_Bienvenido.Size = new Size(197, 39);
            lbl_Bienvenido.TabIndex = 2;
            lbl_Bienvenido.Text = "Bienvenido";
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.BackColor = Color.Transparent;
            lbl_Usuario.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Usuario.ForeColor = SystemColors.ButtonHighlight;
            lbl_Usuario.Location = new Point(521, 349);
            lbl_Usuario.Margin = new Padding(5, 0, 5, 0);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(74, 24);
            lbl_Usuario.TabIndex = 3;
            lbl_Usuario.Text = "Usuario";
            // 
            // lbl_Contraseña
            // 
            lbl_Contraseña.AutoSize = true;
            lbl_Contraseña.BackColor = Color.Transparent;
            lbl_Contraseña.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Contraseña.ForeColor = SystemColors.ButtonHighlight;
            lbl_Contraseña.Location = new Point(503, 416);
            lbl_Contraseña.Margin = new Padding(5, 0, 5, 0);
            lbl_Contraseña.Name = "lbl_Contraseña";
            lbl_Contraseña.Size = new Size(112, 24);
            lbl_Contraseña.TabIndex = 4;
            lbl_Contraseña.Text = "Clave SUBE";
            // 
            // btn_Iniciar
            // 
            btn_Iniciar.Location = new Point(643, 475);
            btn_Iniciar.Margin = new Padding(5, 4, 5, 4);
            btn_Iniciar.Name = "btn_Iniciar";
            btn_Iniciar.Size = new Size(186, 31);
            btn_Iniciar.TabIndex = 6;
            btn_Iniciar.Text = "Iniciar Sesión";
            btn_Iniciar.UseVisualStyleBackColor = true;
            
            // 
            // pic_Fondo
            // 
            pic_Fondo.ErrorImage = null;
            pic_Fondo.Image = (Image)resources.GetObject("pic_Fondo.Image");
            pic_Fondo.InitialImage = null;
            pic_Fondo.Location = new Point(0, 0);
            pic_Fondo.Margin = new Padding(3, 4, 3, 4);
            pic_Fondo.Name = "pic_Fondo";
            pic_Fondo.Size = new Size(1072, 707);
            pic_Fondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Fondo.TabIndex = 7;
            pic_Fondo.TabStop = false;
            // 
            // link_Registracion
            // 
            link_Registracion.AutoSize = true;
            link_Registracion.BackColor = Color.Transparent;
            link_Registracion.Location = new Point(615, 523);
            link_Registracion.Margin = new Padding(5, 0, 5, 0);
            link_Registracion.Name = "link_Registracion";
            link_Registracion.Size = new Size(261, 20);
            link_Registracion.TabIndex = 5;
            link_Registracion.TabStop = true;
            link_Registracion.Text = "No posee una cuenta? Registrese aquí";
            link_Registracion.LinkClicked += link_Registracion_LinkClicked;
            // 
            // PantallaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 692);
            Controls.Add(btn_Iniciar);
            Controls.Add(link_Registracion);
            Controls.Add(lbl_Contraseña);
            Controls.Add(lbl_Usuario);
            Controls.Add(lbl_Bienvenido);
            Controls.Add(txt_password);
            Controls.Add(txt_User);
            Controls.Add(pic_Fondo);
            Margin = new Padding(5, 4, 5, 4);
            Name = "PantallaLogin";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Fondo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_User;
        private TextBox txt_password;
        private Label lbl_Bienvenido;
        private Label lbl_Usuario;
        private Label lbl_Contraseña;
        private Button btn_Iniciar;
        private PictureBox pic_Fondo;
        private LinkLabel link_Registracion;
    }
}

