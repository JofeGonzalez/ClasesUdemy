using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerDiaEstudio
{
    public class Personita
    {
        public Personita(string nombresito, string apelledillito, int edadsita, int dniisito, string profesionsita)
        {
            this.nombresito = nombresito;
            this.apellidito = apelledillito;
            this.edadsita = edadsita;
            this.dniisito = dniisito;
            this.profesionsita = profesionsita;
        }

        public string nombresito;
        public string apellidito;
        public int edadsita;
        public int dniisito;
        public string profesionsita;
    }
}
