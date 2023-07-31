using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEscuelita
{
    public class Escuelas
    {
        public List<Escuela> ListEscuela { get; set; }
        public Escuelas()
        {
            ListEscuela = new List<Escuela>();
        }
        public void AgregarNinos(Escuela escuela)
        {
            ListEscuela.Add(escuela);
        }
        public List<Escuela> ImprimirNinos()
        {
            List<Escuela> impninos = new List<Escuela>();
            foreach (Escuela escuela in ListEscuela)
            {
                impninos.Add(escuela);
            }
            return impninos;
        }
    }
}
