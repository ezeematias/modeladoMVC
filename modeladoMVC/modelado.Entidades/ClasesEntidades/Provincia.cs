using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelado.Entidades.ClasesEntidades
{
    public class Provincia
    {
        public int ProvinciaID { get; set; }

        public string NombreProvincia { get; set; }

        public List<Localidad> Localidades { get; set; }
    }
}
