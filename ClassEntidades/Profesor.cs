using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidades
{
    public class Profesor
    {
        public int id_profe { get; set; }
        public int registro_empleado { get; set; }
        public string nombre { get; set; }
        public string ap_pat { get; set; }
        public string ap_mat { get; set; }
        public string genero { get; set; }
        public string categoria { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public int f_edocivil { get; set; }
    }
}
