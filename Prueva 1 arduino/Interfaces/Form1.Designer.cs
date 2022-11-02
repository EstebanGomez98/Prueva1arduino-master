namespace Prueva_1_arduino
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_inicio = new System.Windows.Forms.Button();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.velocidad = new System.Windows.Forms.Label();
            this.Puerto = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Humedad = new System.Windows.Forms.Label();
            this.L_Temperatura = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.L_DireccionV = new System.Windows.Forms.Label();
            this.L_VelocidadV = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.L_Plubiometro = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.datosRecividos);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_inicio);
            this.groupBox2.Controls.Add(this.progressBarConnection);
            this.groupBox2.Controls.Add(this.buttonClose);
            this.groupBox2.Controls.Add(this.buttonOpen);
            this.groupBox2.Controls.Add(this.comboBoxBaudRate);
            this.groupBox2.Controls.Add(this.comboBoxComPort);
            this.groupBox2.Controls.Add(this.velocidad);
            this.groupBox2.Controls.Add(this.Puerto);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 250);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "conexion";
            // 
            // bt_inicio
            // 
            this.bt_inicio.Location = new System.Drawing.Point(93, 212);
            this.bt_inicio.Name = "bt_inicio";
            this.bt_inicio.Size = new System.Drawing.Size(75, 23);
            this.bt_inicio.TabIndex = 17;
            this.bt_inicio.Text = "Inicio";
            this.bt_inicio.UseVisualStyleBackColor = true;
            this.bt_inicio.Click += new System.EventHandler(this.bt_inicio_Click);
            // 
            // progressBarConnection
            // 
            this.progressBarConnection.Location = new System.Drawing.Point(19, 171);
            this.progressBarConnection.Name = "progressBarConnection";
            this.progressBarConnection.Size = new System.Drawing.Size(236, 23);
            this.progressBarConnection.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(154, 121);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Desconectar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(29, 121);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Conectar";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "11600"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(124, 61);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 3;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(124, 31);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 2;
            // 
            // velocidad
            // 
            this.velocidad.AutoSize = true;
            this.velocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocidad.Location = new System.Drawing.Point(26, 61);
            this.velocidad.Name = "velocidad";
            this.velocidad.Size = new System.Drawing.Size(78, 16);
            this.velocidad.TabIndex = 1;
            this.velocidad.Text = "Velocidad";
            // 
            // Puerto
            // 
            this.Puerto.AutoSize = true;
            this.Puerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puerto.Location = new System.Drawing.Point(26, 31);
            this.Puerto.Name = "Puerto";
            this.Puerto.Size = new System.Drawing.Size(52, 16);
            this.Puerto.TabIndex = 0;
            this.Puerto.Text = "Puerto";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(22, 19);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Temperatura";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Humedad";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(513, 194);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.L_Humedad);
            this.groupBox1.Controls.Add(this.L_Temperatura);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(295, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(651, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "C°";
            // 
            // L_Humedad
            // 
            this.L_Humedad.AutoSize = true;
            this.L_Humedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Humedad.Location = new System.Drawing.Point(550, 143);
            this.L_Humedad.Name = "L_Humedad";
            this.L_Humedad.Size = new System.Drawing.Size(98, 33);
            this.L_Humedad.TabIndex = 9;
            this.L_Humedad.Text = "labelH";
            // 
            // L_Temperatura
            // 
            this.L_Temperatura.AutoSize = true;
            this.L_Temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Temperatura.Location = new System.Drawing.Point(550, 49);
            this.L_Temperatura.Name = "L_Temperatura";
            this.L_Temperatura.Size = new System.Drawing.Size(95, 33);
            this.L_Temperatura.TabIndex = 8;
            this.L_Temperatura.Text = "labelT";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.L_DireccionV);
            this.groupBox3.Controls.Add(this.L_VelocidadV);
            this.groupBox3.Controls.Add(this.chart2);
            this.groupBox3.Location = new System.Drawing.Point(15, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 283);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Viento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "km/h";
            // 
            // L_DireccionV
            // 
            this.L_DireccionV.AutoSize = true;
            this.L_DireccionV.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_DireccionV.Location = new System.Drawing.Point(638, 112);
            this.L_DireccionV.Name = "L_DireccionV";
            this.L_DireccionV.Size = new System.Drawing.Size(115, 33);
            this.L_DireccionV.TabIndex = 9;
            this.L_DireccionV.Text = "labelDir";
            // 
            // L_VelocidadV
            // 
            this.L_VelocidadV.AutoSize = true;
            this.L_VelocidadV.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_VelocidadV.Location = new System.Drawing.Point(178, 234);
            this.L_VelocidadV.Name = "L_VelocidadV";
            this.L_VelocidadV.Size = new System.Drawing.Size(96, 33);
            this.L_VelocidadV.TabIndex = 8;
            this.L_VelocidadV.Text = "labelV";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(22, 19);
            this.chart2.Name = "chart2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Velocidad";
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(579, 194);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.L_Plubiometro);
            this.groupBox4.Controls.Add(this.chart3);
            this.groupBox4.Location = new System.Drawing.Point(788, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 283);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Viento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "mm";
            // 
            // L_Plubiometro
            // 
            this.L_Plubiometro.AutoSize = true;
            this.L_Plubiometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Plubiometro.Location = new System.Drawing.Point(99, 231);
            this.L_Plubiometro.Name = "L_Plubiometro";
            this.L_Plubiometro.Size = new System.Drawing.Size(119, 33);
            this.L_Plubiometro.TabIndex = 9;
            this.L_Plubiometro.Text = "labelPlu";
            // 
            // chart3
            // 
            chartArea6.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart3.Legends.Add(legend6);
            this.chart3.Location = new System.Drawing.Point(22, 19);
            this.chart3.Name = "chart3";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Plubiometro";
            this.chart3.Series.Add(series8);
            this.chart3.Size = new System.Drawing.Size(325, 194);
            this.chart3.TabIndex = 7;
            this.chart3.Text = "chart3";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1189, 597);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label velocidad;
        private System.Windows.Forms.Label Puerto;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ProgressBar progressBarConnection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label L_Humedad;
        private System.Windows.Forms.Label L_Temperatura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label L_VelocidadV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label L_DireccionV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label L_Plubiometro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_inicio;
    }
}

