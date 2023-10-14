using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using WindowsFormsApp1;
using System.Text.Json;
using static System.Windows.Forms.DataFormats;

namespace Proyecto_Final_SUBE
{
    public partial class PantallaRegistrarse : Form
    {
        private string registroJSON;
        public PantallaRegistrarse()
        {
            InitializeComponent();
        }



        private void botonCircular1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDni.Text;
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            if (dni.Length == 8 && int.TryParse(dni, out _) == true)
            {
                if (MessageBox.Show("Perfecto", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                    PantallaLogin pr = new PantallaLogin();
                    pr.Show();
                }

            }
            else
            {
                MessageBox.Show("Reingrese DNI valido", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            ulong dniu = Convert.ToUInt64(dni);// string a ulong despues de validar 


            Usuario usuarioObject = new Usuario
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dniu,
                User = usuario,
                Contraseña = contraseña
            };// se pasa la data de la registracion a clase Usuario

            // Hago un string para display en message box

            //MessageBox.Show(userData, "Información del Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
           registroJSON = System.Text.Json.JsonSerializer.Serialize(usuarioObject);
           registroJSON += Environment.NewLine;
            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\tobia_xd43x45\OneDrive\Escritorio\SUBE\Proyecto_Final_SUBE\JSON.txt"))
            {
                streamWriter.WriteLine(registroJSON);
            }
                
        }
     

       

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

