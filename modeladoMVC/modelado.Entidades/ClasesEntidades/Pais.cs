using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelado.Entidades.ClasesEntidades
{
    public class Pais
    {
        public int PaisID { get; set; }

        public string NombrePais { get; set; }

        public List<Provincia> Provincias { get; set; }
    }
}
