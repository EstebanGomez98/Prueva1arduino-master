using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueva_1_arduino
{
    public class Estac_Meteorologica
    {

        public int Type_Com { get; set; }
        public int Dir_Escalvo { get; set; }
        public string Funcion { get; set; }
        public int Dir_Registro { get; set; }
        public int Crc { get; set; }
        public string Usuario { get; set; }
        public string Upa { get; set; }
        public string Date { get; set; }//pasarlo a tipo fecha
        public List<data_rx> Data_rx { get; set; }
    }
    public class data_rx
    {
        public double Temperatura { get; set; }
        public double Humedad { get; set; }
        public double VelocidadViento { get; set; }
        public double DirViento { get; set; }
        public double Lluvia { get; set; }
    }
}
