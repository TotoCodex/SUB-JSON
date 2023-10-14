using Proyecto_Final_SUBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            

            PantallaLogin pantallaLogin = new PantallaLogin();
            pantallaLogin.Show();
            //Application.Run(PantallaLogin()); esto hacia que esté anclado el programa al form login por lo que si cerraba el login que sostenia todo el programa, se cerraba todo el programa
            Application.Run();
            



        }
       
        
        
        


          
        
    }
}