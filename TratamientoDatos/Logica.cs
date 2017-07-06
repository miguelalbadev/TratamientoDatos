using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamientoDatos {
    public class Logica {

        public string MuestraDatos(Datos d) {
            string cadena;
            cadena = d.Nombre + "---" + d.PrimerNumero + "---" + d.SegundoNumero;
            return cadena;
        }
    }
}
