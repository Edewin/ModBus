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
using System.Net.Sockets;
using Modbus.Device;


namespace VS2012nModBus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Variabile


        //Available ports
        private string[] avPorts = SerialPort.GetPortNames();
        private static string portName;
        
        //some variables
        private SerialPort serialport;
        private IModbusSerialMaster modbus;
        private static bool conectat = false;
        private TcpClient tcpClient;
        private ModbusSerialMaster master;

        private TcpClient modTcpClient;
        private ModbusIpMaster modTCPmaster;
        
        //imi da eroarea de tip MessageBox o singura data;
        private static bool messBxCount = true;

        #endregion


        #region Read Algodue

        // adaptata pentru contorul de energie Algodue
        private double readAlgodue(byte id, ushort adresa, ushort nrReg)
        {
            ushort[] registers;
            try
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    registers = modbus.ReadHoldingRegisters(id, adresa, nrReg);
                }
                else if (tabControl1.SelectedIndex == 2)
                {
                    registers = modTCPmaster.ReadHoldingRegisters(id, adresa, nrReg);
                }
                else
                {
                    registers = master.ReadHoldingRegisters(id, adresa, nrReg);

                }
                string msg = Convert.ToString(registers[2], 16) + Convert.ToString(registers[3], 16);
                double valoarea = Convert.ToDouble(Convert.ToInt32(msg, 16)) / (double)1000;
                return valoarea;
            }
            catch (Exception ex)
            {
                timer1.Enabled = false;
                if (messBxCount)
                {
                    messBxCount = false;
                    MessageBox.Show(ex.Message, "Eroare!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.AppendText("\n time out...\n");
                    button2.Text = ex.Message;
                    button2.Enabled = false;
                }
                return -1;
            }

        }
        #endregion


        #region Butonul de Conectare pe Serial
        private void button1_Click(object sender, EventArgs e)
        {
            if (selected == 0)
                {
                try
                {
                
                        //create serialport
                        serialport = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
                        serialport.ReadTimeout = 2000;
                        //create modbus rtu
                        modbus = ModbusSerialMaster.CreateRtu(serialport);
                        serialport.Open();
                        textBox1.Text = "Conectat" + Environment.NewLine;
                        conectat = true;

                        button1.Enabled = false;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        comboBox1.Enabled = false;
                 }
                 catch (Exception ex)
                 {
                      MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK);
                 }
                }
               /* else
                {
                    try 
	                {	 
		                //create TCP client
                        tcpClient = new TcpClient(Convert.ToString(textSetIP.Text), Convert.ToInt32(textSetPort));
                        MessageBox.Show(Convert.ToString(textSetIP.Text) + Convert.ToInt32(textSetPort));
                        master = ModbusSerialMaster.CreateRtu(tcpClient);
                	}
	                catch (Exception ex)
	                {
		
		                MessageBox.Show(ex.Message);
	                }
                   
                }*/
            }
           
        
        #endregion

        #region Butonul de Start pe Serial
        private static bool btnStartState = false; 
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (btnStartState == false)
            {
                btnStartState = true;
                button2.BackColor = Color.Red;
                button2.Text = "STOP";
                timer1.Enabled = true;
            }
            else {
                btnStartState = false;
                button2.Text = "Start";
                button2.BackColor = Color.Lime;
                timer1.Enabled = false;
            }
        }
        #endregion

        #region Butonul de deconectare pe Serial

        private void button3_Click(object sender, EventArgs e)
        {
            messBxCount = true;
            try
            {
                serialport.Close();
                serialport = null;
                modbus = null;
                timer1.Enabled = false;
                conectat = false;
                textBox1.AppendText(Environment.NewLine + "Deconectat");
                button1.Enabled = true;
                button2.Enabled = false;
                button2.Text = "Start";
                button2.BackColor = Color.Lime;
                button3.Enabled = false;
                comboBox1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare la deconectare!");
            }
            
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (conectat==false)
            {
                button1.Enabled = true;
                portName = comboBox1.SelectedItem.ToString();
                //MessageBox.Show(portName);
            }
            
        }


        #region Timer

        private static double counter=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //citeste valoare contor si adauga la grafic
            double valTensiune =readAlgodue(Convert.ToByte(numID.Value), 
                                            Convert.ToUInt16(numAdresa.Value), 
                                            Convert.ToUInt16(numCuvinte.Value));
            double valFrecventa = readAlgodue(1, 140, 4); 
            if (autoY.Checked == true)
            {
                //tensiune
                chart1.ChartAreas[0].AxisY.Maximum = valTensiune + 2;
                chart1.ChartAreas[0].AxisY.Minimum = valTensiune - 2;
                textBox1.AppendText("Tensiunea: " + Convert.ToString(valTensiune) + Environment.NewLine);
               // chart1.Series[0].Points.AddXY(counter, valTensiune);
                //frecventa
                chart1.ChartAreas[0].AxisY2.Maximum = valFrecventa + 0.2;
                chart1.ChartAreas[0].AxisY2.Minimum = valFrecventa - 0.2;
                textBox1.AppendText("Frecventa: " +Convert.ToString(valFrecventa) + Environment.NewLine);
               // chart1.Series[1].Points.AddXY(counter, valFrecventa);
            }
            if (counter > Convert.ToDouble(setInterval.Value))
            {
                chart1.ChartAreas[0].AxisX.Minimum = counter - Convert.ToDouble(setInterval.Value);
                chart1.ChartAreas[0].AxisX2.Minimum = counter - Convert.ToDouble(setInterval.Value);
            }
            chart1.Series[0].Points.AddXY(counter, valTensiune);
            chart1.Series[1].Points.AddXY(counter, valFrecventa);
            counter++;

        }
        #endregion


        private void setInterval_ValueChanged(object sender, EventArgs e)
        {
          /*  if (counter > Convert.ToDouble(setInterval.Value))
            {
                chart1.ChartAreas[0].AxisX.Minimum = counter - Convert.ToDouble(setInterval.Value);
            }
           */
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[1].BorderWidth = 3;
            chart1.Series[0].Color = Color.Red;
            chart1.Series[1].Color = Color.Blue;
        }

        private void latimeTensiune_ValueChanged(object sender, EventArgs e)
        {
            chart1.Series[0].BorderWidth = Convert.ToInt32(latimeTensiune.Value);
            chart1.Series[1].BorderWidth = Convert.ToInt32(latimeTensiune.Value);
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

        private static int selected = 0;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = tabControl1.SelectedIndex;
            if (selected ==0)
            {
                chart1.Series[0].Name = "Tensiune";
                chart1.Series[1].Name = "Frecventa";
                textBox1.Text = "Mod: Serial";
                button2.Text = "Start";
                button2.BackColor = Color.Lime;
               
            }
            else if(selected ==1)
            {
                textBox1.Text = "Mod: RTU over TCP/IP";
                chart1.Series[0].Name = "Test values";
                chart1.Series[1].Name = "Not Implemented...";
                
            }
            else
            {
                textBox1.Text = "Mod: ModBus TCP/IP";
                chart1.Series[0].Name = "Test values";
                chart1.Series[1].Name = "Not Implemented...";  
            }
            
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            avPorts = SerialPort.GetPortNames();
             foreach (var port in avPorts)
            {
                comboBox1.Items.Add(port);
            }
        }
        
        
        #region TCP


        #region Butonul de conectare TCP
        
        //stare buton
        private static bool btState = false;    
        
        private void btnConTCP_Click(object sender, EventArgs e)
        {
            if (btState == false)
            {
                btnConTCP.Text = "Disconnect";
                btState = true;
                try
                {
                    //create TCP client
                    tcpClient = new TcpClient(textSetIP.Text, Convert.ToInt16(textSetPort.Text));
                    tcpClient.SendTimeout = 2000;
                    tcpClient.ReceiveTimeout = 2000;
                   // tcpClient = new TcpClient("46.97.201.40", 8080);
                    //MessageBox.Show(textSetIP.Text + Convert.ToInt32(textSetPort));
                    master = ModbusSerialMaster.CreateRtu(tcpClient);
                    textBox1.AppendText(Environment.NewLine + "Conectat");
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                   
                
            }
            else
            {
                btnConTCP.Text = "Connect";
                btState = false;
                master = null;
                textBox1.AppendText(Environment.NewLine + "Deconectat");
            }
            

        }
        #endregion


        #region Butonul de Testare

        private void testBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double dataTCP = readAlgodue(Convert.ToByte(numID.Value),
                                            Convert.ToUInt16(numAdresa.Value),
                                            Convert.ToUInt16(numCuvinte.Value));
                textBox1.AppendText(Environment.NewLine + Convert.ToString(dataTCP ));
               
                if (autoY.Checked)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = dataTCP + 2;
                    chart1.ChartAreas[0].AxisY.Minimum = dataTCP - 2;
                }
                
                if (counter > Convert.ToDouble(setInterval.Value))
                {
                    chart1.ChartAreas[0].AxisX.Minimum = counter - Convert.ToDouble(setInterval.Value);
                }
                
                chart1.Series[0].Points.AddXY(counter, dataTCP);
                
                counter++;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        #endregion

        #region Butonul de Conectare pe ModBus TCP/IP

        private static bool btn2State = false;
        private void btnConnectModTCP_Click(object sender, EventArgs e)
        {
            if (btn2State == false)
            {
                btn2State = true;
                btnConnectModTCP.Text= "Disconnect";
                try
                {
                    modTcpClient = new TcpClient(txtBoxMBTCPsetIP.Text, Convert.ToInt32(txtBoxMBTCPsetPort.Text));
                    modTcpClient.ReceiveTimeout = 2000;
                    modTcpClient.SendTimeout = 2000;
                    modTCPmaster = ModbusIpMaster.CreateIp(modTcpClient);
                    textBox1.AppendText(Environment.NewLine + "Conectat");
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
        	{
                btnConnectModTCP.Text = "Connect";
                modTCPmaster = null;
                btn2State = false;
                textBox1.AppendText(Environment.NewLine + "Deconectat");

	        }
        }

        #endregion


        #region Butonul de citire pe ModBus TCP/IP

        private void btnReadModTCP_Click(object sender, EventArgs e)
        {
            try
            {
                double dataTCP = readAlgodue(Convert.ToByte(numID.Value),
                                            Convert.ToUInt16(numAdresa.Value),
                                            Convert.ToUInt16(numCuvinte.Value));
                textBox1.AppendText(Environment.NewLine + Convert.ToString(dataTCP));

                if (autoY.Checked)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = dataTCP + 2;
                    chart1.ChartAreas[0].AxisY.Minimum = dataTCP - 2;
                }

                if (counter > Convert.ToDouble(setInterval.Value))
                {
                    chart1.ChartAreas[0].AxisX.Minimum = counter - Convert.ToDouble(setInterval.Value);
                }

                chart1.Series[0].Points.AddXY(counter, dataTCP);

                counter++;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        #endregion

        #endregion
    }
}
