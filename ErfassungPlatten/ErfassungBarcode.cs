using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;

namespace ErfassungPlatten
{
    public partial class ErfassungBarcode : Form
    {

        public ErfassungBarcode()
        {
            InitializeComponent();
            textBoxInventarNo.Text = "202110000";
            LabelScanner.Text = "nicht Aktiv";
            LabelScanner.ForeColor = System.Drawing.Color.Red;
            serialPort1.PortName = "COM6";
        }


        private void ErfassungPlatten_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                timer1.Start();
                LabelScanner.Text = "Aktiv";
                LabelScanner.ForeColor = System.Drawing.Color.Green;
                radioButtonCom1.Enabled = false;
                radioButtonCom2.Enabled = false;
                radioButtonCom3.Enabled = false;
                radioButtonCom4.Enabled = false;
                radioButtonCom5.Enabled = false;
                radioButtonCom6.Enabled = false;
                radioButtonCom7.Enabled = false;
                radioButtonCom8.Enabled = false;
                button3.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Com Port ist nicht verfügbar!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string A = serialPort1.ReadExisting();
            string B;
                        
            if (A != "")

            {
                richTextBox1.AppendText(A);
                B = (richTextBox1.Lines[richTextBox1.Lines.Length - 2]);
                richTextBox1.ScrollToCaret();
                if (B.Length < 30)
                {
                    MessageBox.Show("Barcode ist keine NVE!");
                }
                else
                textBoxNVE.Text = B.Substring(10, 20);
               
                if (radioButtonDatabase.Checked == true)
                {
                   NVEInsert();
                }
                else
                
                NVEcsv();

            }
                              
        }



        private void NVEcsv()

        {
           
                string newFileName = "C:\\Inventur/"+ textBoxInventarNo.Text +".csv";

                string nveDetails = textBoxInventarNo.Text + ";" + textBoxNVE.Text + ";" + DateTime.Now + Environment.NewLine; ;

            if (!File.Exists(newFileName))
            {
                string nveHeader = "InventarNo" + ";" + "NVE" + ";" + "ScanTime" + Environment.NewLine;

                File.WriteAllText(newFileName, nveHeader);
            }

                File.AppendAllText(newFileName, nveDetails);

               

           
        }

        private void NVEInsert()

        {
            try
            {
                
                SqlConnection con = new SqlConnection(@"Data Source = 1.1.1.1; Initial Catalog= Datenbank; User ID = user; Password = user");
                SqlCommand cmd = new SqlCommand("INSERT INTO Tabelle (ID, Barcode, InventarNo, ScanTime) VALUES (1," + textBoxNVE.Text + "," + textBoxInventarNo.Text + ", GETDATE())", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                
            }
            catch
            {
                MessageBox.Show("SQL Fehler, Barcode wurde nicht im Inventar erfasst!");
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            serialPort1.Close();
            LabelScanner.Text = "nicht Aktiv";
            LabelScanner.ForeColor = System.Drawing.Color.Red;
            radioButtonCom1.Enabled = true;
            radioButtonCom2.Enabled = true;
            radioButtonCom3.Enabled = true;
            radioButtonCom4.Enabled = true;
            radioButtonCom5.Enabled = true;
            radioButtonCom6.Enabled = true;
            radioButtonCom7.Enabled = true;
            radioButtonCom8.Enabled = true;
            button3.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButtonCom1.Checked == true)
            {
                serialPort1.PortName = "COM1";
            }
            else

            if (radioButtonCom2.Checked == true)
            {
                serialPort1.PortName = "COM2";
            }
            else

            if (radioButtonCom3.Checked == true)
            {
                serialPort1.PortName = "COM3";
            }
            else

            if (radioButtonCom4.Checked == true)
            {
                serialPort1.PortName = "COM4";
            }
            else

            if (radioButtonCom5.Checked == true)
            {
                serialPort1.PortName = "COM5";
            }
            else

            if (radioButtonCom6.Checked == true)
            {
                serialPort1.PortName = "COM6";
            }
            else

            if (radioButtonCom7.Checked == true)
            {
                serialPort1.PortName = "COM7";
            }
            else

            if (radioButtonCom8.Checked == true)
            {
                serialPort1.PortName = "COM8";
            }
        }

        private void radioButtonCSV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCSV.Checked == true)
            { radioButtonDatabase.Checked = false; }
        }

        private void radioButtonDatabase_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDatabase.Checked == true)
            { radioButtonCSV.Checked = false; }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
