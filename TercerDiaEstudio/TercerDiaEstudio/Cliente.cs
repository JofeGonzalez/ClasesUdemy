using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerDiaEstudio
{
    public class Cliente:Persona
    {
        private string direccion { get; set; }
        private string gustos { get; set; }
        
        public string getDireccion()
        {
            return direccion;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public string getGustos()
        {
            return gustos;
        }
        public void setGustos(string gustos)
        {
            this.gustos = gustos;
        }
    }
}
