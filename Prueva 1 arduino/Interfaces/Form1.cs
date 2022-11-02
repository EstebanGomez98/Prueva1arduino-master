using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Text.Json;
using Prueva_1_arduino.objetos;
using System.Net;
using static WinFormAnimation.AnimationFunctions;
using Prueva_1_arduino.ApiHelper;
using System.Security.Policy;

namespace Prueva_1_arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            buttonOpen.Enabled = true;
            buttonClose.Enabled = false;
            comboBoxBaudRate.Text = "9600";
            progressBarConnection.Value = 0;

            string[] puertos = SerialPort.GetPortNames();
            comboBoxComPort.Items.AddRange(puertos);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                try
                {
                    SerialPort.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort.PortName = comboBoxComPort.Text;
                SerialPort.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                SerialPort.Open();

                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;
                progressBarConnection.Value = 100;
                comboBoxBaudRate.Enabled = false;
                comboBoxComPort.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort.Close();
                buttonOpen.Enabled = true;
                buttonClose.Enabled = false;
                progressBarConnection.Value = 0;
                comboBoxBaudRate.Enabled = true;
                comboBoxComPort.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Resepcion de datos
        private async void datosRecividos(object sender, SerialDataReceivedEventArgs e)
        {
            String Data_in = SerialPort.ReadTo("\n");//resepcion de los datos por puerto serial
            Console.WriteLine(Data_in);//imprecion de los datos

            // tengo que re inventar la rueda

            var DataJson = JsonSerializer.Deserialize<Datos>(Data_in);//deserializacion del json con los datos
            Console.WriteLine(DataJson);//imprecion de los datos
            var uri = "https://localhost:44368/api/DatoEstacionMeteorologica/saveDatoEstacionM";// para enviar los datos
            foreach (var temperatura in DataJson.Datos_a)
            {
                var envioDatosa = new EnvioJson()
                {
                    Id_dato_estacion_meteorologica=0,
                    Id_estacion_meteorologica = temperatura.Id_estacionM,
                    Fecha_hora = temperatura.Fecha_hora,
                    Id_sensor = temperatura.Id_sensor,
                    Valor = temperatura.Valor
                };
                L_Temperatura.Invoke((MethodInvoker)(() =>
                {
                    L_Temperatura.Text = temperatura.Valor.ToString();
                }));
                chart1.Invoke((MethodInvoker)((() =>
                {
                    chart1.Series["Temperatura"].Points.AddY(temperatura.Valor);
                })));

                Reply oReply = new Reply();
                oReply = await Consumer.Execute<EnvioJson>(uri, ApiHelper.methodHttp.POST, envioDatosa);
                MessageBox.Show(oReply.StatusCode);
            }

            //Humedad
            foreach (var humedad in DataJson.Datos_b)
            {
                var envioDatosb = new EnvioJson()
                {
                    Id_dato_estacion_meteorologica = 0,
                    Id_estacion_meteorologica = humedad.Id_estacionM,
                    Fecha_hora = humedad.Fecha_hora,
                    Id_sensor = humedad.Id_sensor,
                    Valor = humedad.Valor
                };
                L_Humedad.Invoke((MethodInvoker)(() =>
                {
                    L_Humedad.Text = humedad.Valor.ToString();
                })); 

                chart1.Invoke((MethodInvoker)((() =>
                {
                    chart1.Series["Humedad"].Points.AddY(humedad.Valor);
                })));
                
            }
            //velocidad del viento
            foreach (var velocidadV in DataJson.Datos_c)
            {
                var envioDatosc = new EnvioJson()
                {
                    Id_dato_estacion_meteorologica = 0,
                    Id_estacion_meteorologica = velocidadV.Id_estacionM,
                    Fecha_hora = velocidadV.Fecha_hora,
                    Id_sensor = velocidadV.Id_sensor,
                    Valor = velocidadV.Valor
                };
                L_VelocidadV.Invoke((MethodInvoker)(() =>
                {
                    L_VelocidadV.Text = velocidadV.Valor.ToString();
                }));
                chart2.Invoke((MethodInvoker)((() =>
                {
                    chart2.Series["Velocidad"].Points.AddY(velocidadV.Valor);
                })));
            }

            foreach (var direccionV in DataJson.Datos_d)
            {
                var envioDatosd = new EnvioJson()
                {
                    Id_dato_estacion_meteorologica = 0,
                    Id_estacion_meteorologica = direccionV.Id_estacionM,
                    Fecha_hora = direccionV.Fecha_hora,
                    Id_sensor = direccionV.Id_sensor,
                    Valor = direccionV.Valor
                };
                L_DireccionV.Invoke((MethodInvoker)(() =>
                {
                    L_DireccionV.Text = direccionV.Valor.ToString();
                }));
            }
            foreach (var cantidadAgua in DataJson.Datos_e)
            {
                var envioDatose = new EnvioJson()
                {
                    Id_dato_estacion_meteorologica = 0,
                    Id_estacion_meteorologica = cantidadAgua.Id_estacionM,
                    Fecha_hora = cantidadAgua.Fecha_hora,
                    Id_sensor = cantidadAgua.Id_sensor,
                    Valor = cantidadAgua.Valor
                };
                chart3.Invoke((MethodInvoker)((() =>
                {
                    chart3.Series["Plubiometro"].Points.AddY(cantidadAgua.Valor);
                })));
                L_Plubiometro.Invoke((MethodInvoker)(() =>
                {
                    L_Plubiometro.Text = cantidadAgua.Valor.ToString();
                }));
            }
        }

            private void bt_inicio_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            var objetoJson2 = new EnvioJson()
            {
                Id_estacion_meteorologica = 1,  
                Fecha_hora = "13",
                Id_sensor = 1,
                Valor =1.0 
            };
            string json2 = JsonSerializer.Serialize(objetoJson2);//serializacion de json de envio
            SerialPort.WriteLine(json2);//envio de peticion al arduino por uerto serial
        }
    }
}
