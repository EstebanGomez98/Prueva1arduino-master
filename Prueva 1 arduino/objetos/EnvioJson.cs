using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueva_1_arduino.objetos
{
    internal class EnvioJson
    {
        public int Id_dato_estacion_meteorologica { get; set; }
        public int Id_estacion_meteorologica { get; set; }
        public string Fecha_hora { get; set; }
        public int Id_sensor { get; set; }
        public double Valor { get; set; }
    }
}
