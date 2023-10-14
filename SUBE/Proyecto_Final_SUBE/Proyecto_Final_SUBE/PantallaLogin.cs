using Proyecto_Final_SUBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class PantallaLogin : Form
    {
        private bool linkRegistracionClicked = false;// Flag por si aprieta el boton de link y cierra el de login para abrir el de Registracion (es para que no me interprete que quiero cerrar el programa)
        public PantallaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Bienvenido.Parent = pic_Fondo;
            lbl_Usuario.Parent = pic_Fondo;
            lbl_Contraseña.Parent = pic_Fondo;
            link_Registracion.Parent = pic_Fondo;


        }

        private void link_Registracion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkRegistracionClicked = true;
            this.Close();//cierra el form PantallaLogin (this. hace referncia a esta clase PantallaLogin)
            PantallaRegistrarse formRegistracion = new PantallaRegistrarse();
            formRegistracion.Show();


        }

        private void pic_Fondo_Click(object sender, EventArgs e)
        {

        }

        private void AccessData()
        {
            // Deserialize the XML into a Usuario object
            Usuario usuarioDeserializado;
            using (StreamReader streamReader = new StreamReader(@"C:\Users\tobia_xd43x45\OneDrive\Escritorio\SUBE\Proyecto_Final_SUBE\JSON.txt"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Usuario));
                usuarioDeserializado = (Usuario)xmlSerializer.Deserialize(streamReader);
            }

            // Get user and password from the input
            string user = userInput;
            string password = passwordInput;

            // Validate the user and password
            if (user == usuarioDeserializado.User && password == usuarioDeserializado.Contraseña)
            {
                if (MessageBox.Show("Logeado", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    PantallaPrincipal pp = new PantallaPrincipal();
                    pp.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario/Clave Incorrecta", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && linkRegistracionClicked == false)
            {
                if (MessageBox.Show("¿Desea Salir realmente?\nPara volver presione Cancel", "Exiting", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    Application.Exit();
                }

            }

        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
