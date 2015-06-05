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
using Modbus.Device;


namespace VS2012nModBus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var port in avPorts)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                //create serialport
                serialport = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
                //create modbus rtu
                modbus = ModbusSerialMaster.CreateRtu(serialport);
                serialport.Open();
                textBox1.Text = "Conectat" + Environment.NewLine;
                conectat = true;
                timer1.Enabled = true;
                button1.Enabled = false;
                button3.Enabled = true;
            }
            catch (Exception )
            {

                MessageBox.Show("Eroare! Nu am reusit sa ma conectez la portul serial!\n\nResetati programul");
            }
        }
       
        //Available ports
        private string[] avPorts = SerialPort.GetPortNames();
        private static string portName;
        //some variables
        private SerialPort serialport;
        private IModbusSerialMaster modbus;
        private static bool conectat = false;
        private byte slaveId = 1;
        private ushort startAdress = 4;
        private ushort numRegisters = 4;

        // some methods

        // adaptata pentru contorul de energie Algodue
        private double readAlgodue(byte id, ushort adresa, ushort nrReg)
        {
            try
            {
                ushort[] registers = modbus.ReadHoldingRegisters(id, adresa, nrReg);
                string msg = Convert.ToString(registers[2], 16) + Convert.ToString(registers[3], 16);
                double valoarea = Convert.ToDouble(Convert.ToInt32(msg, 16)) / (double)1000;
                return valoarea;
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare! Trebuie sa fii conectat!");
                return -1;
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
         double val = readAlgodue(slaveId, startAdress, numRegisters);
         textBox1.AppendText(Convert.ToString(val) + Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Close();
                serialport = null;
                modbus = null;
                timer1.Enabled = false;
                conectat = false;
                textBox1.AppendText(Environment.NewLine + "Deconectat");
                button1.Enabled = true;
                button3.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la deconectare!");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (conectat==false)
            {
                button1.Enabled = true;
                portName = comboBox1.SelectedItem.ToString();
                //MessageBox.Show(portName);
            }
            
        }

        private static double counter=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //citeste valoare contor si adauga la grafic
            double valTensiune =readAlgodue(1, 4, 4);
            if (autoY.Checked == true)
            {
                chart1.ChartAreas[0].AxisY.Maximum = valTensiune + 2;
                chart1.ChartAreas[0].AxisY.Minimum = valTensiune - 2;
            }
            if (counter > Convert.ToDouble(setInterval.Value))
            {
                chart1.ChartAreas[0].AxisX.Minimum = counter - Convert.ToDouble(setInterval.Value);
            }
            chart1.Series[0].Points.AddXY(counter, valTensiune);
            counter++;

        }

        private void setInterval_ValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToDouble(setInterval.Value) < counter)
            chart1.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(setInterval.Value);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void latimeTensiune_ValueChanged(object sender, EventArgs e)
        {
            chart1.Series[0].BorderWidth = Convert.ToInt32(latimeTensiune.Value);
        }

        private void Ymax_ValueChanged(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(Ymax.Value);
        }

        private void Ymin_ValueChanged(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(Ymin.Value);
        }

        private void autoY_CheckedChanged(object sender, EventArgs e)
        {
            if (autoY.Checked == true)
            {
                Ymax.Enabled = false;
                Ymin.Enabled = false;
            }
            else
            {
                Ymax.Enabled = true;
                Ymin.Enabled = true;
            }
        }
    }
}
