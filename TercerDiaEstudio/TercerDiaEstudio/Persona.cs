using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerDiaEstudio
{
    public class Persona
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int edad { get; set; }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
    }
}
