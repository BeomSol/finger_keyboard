using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void chkComm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComm.Checked)
            {
                bool success = SPort.OpenPorts(serialPort, Convert.ToInt32(txtPortNum.Text));
                if (!success)
                {
                    MessageBox.Show("시리얼포트를 열지 못했습니다", "오류");
                }
            }
            else
            {
                SPort.ClosePorts(serialPort);
            }
        }

        private void timCommMon_Tick(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) return;

            //---------------------------------------------
            // Digital Input & AD
            //---------------------------------------------
            setCommLamp(true);

            string answer = "";
            bool success = TComm.RecieveText(serialPort,ref answer);
            if(success)
                txtDialog.Text += "" + answer + "\r\n";
        }

        private void setCommLamp(bool isOn)
        {
            picComm.Image = (isOn) ? Properties.Resources.LampOn : Properties.Resources.LampOff;
        }

        private void timLampOff_Tick(object sender, EventArgs e)
        {
            setCommLamp(false);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) return;

            string st = txtSend.Text.Trim();
            if (st.Length <= 0) return;

            TComm.SendText(serialPort, st);
            txtDialog.Text += "[Me] " + st + "\r\n";
            txtSend.Text = "";
        } 

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') btnSend.PerformClick();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDialog.Text = "";
        }
    }
}
