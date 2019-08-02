using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBTest
{
    public partial class frm_e911 : Form
    {
        private SqlConnection sconn = new SqlConnection();
        private SqlCommand scmd = new SqlCommand();

        public frm_e911()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopConnection();
            if (Connection != null)
            {
                Connection.StateChanged -= Connection_StateChanged;
                Connection.Closed -= Connection_Closed;
                Connection.Error -= Connection_Error;
                Connection.Dispose();
            }
        }

        private void btnDisconnectSignalR_Click(object sender, EventArgs e)
        {
            StopConnection();
        }

        private void btnMsgCountReset_Click(object sender, EventArgs e)
        {
            _ReconnectingCount = 0;
            txtMsgCount.Text = _ReconnectingCount.ToString();
            rtfE911Messages.Clear();
            Application.DoEvents();
        }

        private void btnConnectSignalR_Click(object sender, EventArgs e)
        {
            SignalRConnect();
        }
    }
}
