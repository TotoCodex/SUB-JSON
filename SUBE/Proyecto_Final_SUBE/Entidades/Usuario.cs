using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Proyecto_Final_SUBE
{
    [Serializable]
    public class Usuario:Persona
    {
        private string user;
        private string contraseña;
        

        public Usuario()
        {
        }

        public Usuario(string nombre, string apellido, ulong dni, string usuario, string contraseña)
            : base (nombre,apellido,dni)
        {
            this.user = usuario;
            this.contraseña = contraseña;
            
        }

        
        public string User { get => user; set => user = value; }

       
        public string Contraseña { get => contraseña; set => contraseña = value; }

        
        


    }
}
