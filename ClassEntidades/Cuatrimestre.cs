using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidades
{
    public class Cuatrimestre
    {
        public int id_cuatrimestre { get; set; }
        public string periodo { get; set; }
        public int anio { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public string extra { get; set; }
    }
}
