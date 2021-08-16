using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidades
{
    public class GrupoCuatrimestre
    {
        public int id_grucuat{ get; set; }
        public int f_proged { get; set; }
        public int f_grupo { get; set; }
        public int f_cuatri { get; set; }
        public string turno { get; set; }
        public string modalidad { get; set; }
        public string extra { get; set; }
    }
}
