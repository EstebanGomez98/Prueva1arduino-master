using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueva_1_arduino.objetos
{
    public class Datos
    {
        public List<data> Datos_a { get; set; }
        public List<data> Datos_b { get; set; }
        public List<data> Datos_c { get; set; }
        public List<data> Datos_d { get; set; }
        public List<data> Datos_e { get; set; }
    }
    public class data
    {
        public int Id_estacionM { get; set; }
        public string Fecha_hora { get; set; }
        public int Id_sensor { get; set; }
        public double Valor { get; set; }
    }
}
