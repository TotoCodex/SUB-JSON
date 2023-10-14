using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_SUBE
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private ulong dni;

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, ulong dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public ulong Dni { get => dni; set => dni = value; }
    }
}
