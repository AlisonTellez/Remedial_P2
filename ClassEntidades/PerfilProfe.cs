using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidades
{
    public class PerfilProfe
    {
        public int id_perfil { get; set; }
        public int f_profe { get; set; }
        public int f_grado { get; set; }
        public string estado { get; set; }
        public DateTime fecha_obtencion { get; set; }
        public string evidencia { get; set; }
    }
}
