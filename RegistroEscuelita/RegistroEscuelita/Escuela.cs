using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEscuelita
{
    public class Escuela
    {
        public string NombresB { get; set; }
        public string ApellidosB{ get; set; }
        public int CedulaB { get; set; }
        public string Curso { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public string NombresP { get; set; }
        public int Celular { get; set; }
        public int CedulaP { get; set; }
        public Escuela()
        {
        }

        public Escuela(string nombresb,string apellidosb, int cedulab, string genero, int edad, string nombresp, int celular, int cedulap,string curso)
        {

            NombresB = nombresb;
            ApellidosB = apellidosb;
            CedulaB = cedulab;
            Genero = genero;
            Edad = edad;
            NombresP = nombresp;
            Celular = celular;
            CedulaP = cedulap;
            Curso = curso;


        }

    }
  
}
