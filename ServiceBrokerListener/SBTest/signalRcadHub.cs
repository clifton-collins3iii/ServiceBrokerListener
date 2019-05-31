using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client.Transports;
using Microsoft.AspNet.SignalR.Client;
using Newtonsoft.Json;
using Models;


namespace SBTest
{
    public partial class Form1 : Form
    {
        #region Variables
        public static HubConnection Connection { get; set; }
        private static IHubProxy HubProxy { get; set; }
        private static readonly Random HeartbeatRandomization = new Random();
        private static int HeartbeatBaseTimeInMinutes = 300;
        private static readonly System.Timers.Timer HeartbeatTimer = new System.Timers.Timer(HeartbeatBaseTimeInMinutes) { AutoReset = false };
        private static int _ConnectingCount = 0;
        private static int _ReconnectingCount = 0;
        public static bool _ApplicationClosing = false;
        private static bool _DisabledByAuthenticationManager = false;
        #endregion

        private void SignalRConnect()
        {
            CreateConnection();

            HubProxy.On<cadE911Log>("SendE911Log", OnSendE911Log);

            StartConnection();
        }

        private void OnSendE911Log(cadE911Log log)
        {
            try
            {
                UpdatetxtrtfCadE911Messages($"{log.StationID}, {log.AddressNumber} - {log.LastName}\n");
                _ReconnectingCount++;
                UpdatetxtMsgCount(_ReconnectingCount.ToString());
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateConnection()
        {
           
            //Connection = new HubConnection("http://opertest1:8080/signalr");
            string l_url;
            l_url = txtSignalRServerURL.Text;
            //l_url = new ClientConfigurationSettings().PlatinumServerURL;
            //if (string.IsNullOrEmpty(l_url))
            //    UserSettings.getGlobalCDRSetting("CadSignalR.URL", "Cad SignalR", out l_url);

            Connection = new HubConnection(l_url);
            HubProxy = Connection.CreateHubProxy("CadHub");
            Connection.Headers.Add("IsController", "False");
            Connection.Headers.Add("ptsUserID", "SBTest");
            Connection.Headers.Add("ConnectionString", "None");
            Connection.Headers.Add("CurrentUser", JsonConvert.SerializeObject("SBTesting"));
            HubProxy["UserName"] = "SBTesting";
            HubProxy["ptsUserID"] = "SBTest";
            HubProxy["Host"] = Environment.MachineName;
        }

        private void StartConnection()
        {
            try
            {
                Connection.StateChanged += Connection_StateChanged;
                Connection.Closed += Connection_Closed;
                Connection.Error += Connection_Error;
                //Connection.Reconnected += Connection_Reconnected;
                //Connection.Reconnecting += Connection_Reconnecting;
                Connection.Start();

            }
            catch (Exception ex)
            {
                //erroring here
                MessageBox.Show(ex.Message);
            }
        }

        public void StopConnection()
        {
            
            Exception de = new Exception("Default Stop reason");
            StopConnection(de, new TimeSpan(0, 0, 10));
           
        }

        public void StopConnection(Exception sce, TimeSpan waitCloseTimeout)
        {
            try
            {
                if (Connection != null)
                {
                    HeartbeatTimer.Stop();
                    if (Connection.State != ConnectionState.Connected)
                    {
                        Connection.Stop(sce, waitCloseTimeout);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Connection_Error(Exception ce)
        {
            MessageBox.Show(ce.Message);
        }

        private void UpdatetxtMsgCount(string messagetext)
        {
            if (txtMsgCount.InvokeRequired == true)
                txtMsgCount.Invoke((MethodInvoker)delegate { txtMsgCount.Text = messagetext; });

            else
                txtMsgCount.Text = messagetext;
        }

        private void UpdatetxtSignalRStatus(string messagetext)
        {
            if (txtSignalRStatus.InvokeRequired == true)
                txtSignalRStatus.Invoke((MethodInvoker)delegate { txtSignalRStatus.Text = messagetext; });

            else
                txtSignalRStatus.Text = messagetext;
        }

        private void UpdatetxtrtfCadE911Messages(string messagetext)
        {
            if (rtfE911Messages.InvokeRequired == true)
                rtfE911Messages.Invoke((MethodInvoker)delegate { rtfE911Messages.AppendText(messagetext); rtfE911Messages.ScrollToCaret(); });
            else
                rtfE911Messages.Text = messagetext;
        }

        private void Connection_StateChanged(StateChange obj)
        {
            if (_DisabledByAuthenticationManager) return;
            switch (obj.NewState)
            {
                case ConnectionState.Connected:
                {
                    UpdatetxtSignalRStatus("Connected");
                    break;
                }
                case ConnectionState.Connecting:
                {
                    _ConnectingCount++;
                    UpdatetxtSignalRStatus("Connecting");
                    break;
                }
                case ConnectionState.Disconnected:
                {
                    UpdatetxtSignalRStatus("Disconnected");
                    break;
                }
                case ConnectionState.Reconnecting:
                {
                    UpdatetxtSignalRStatus("Reconnecting");
                    break;
                }
            }
            Application.DoEvents();
        }

        private void Connection_Closed()
        {
            //Task.Delay(TimeSpan.FromSeconds(1));    // delay one second to stop potential reconnect storm
            UpdatetxtSignalRStatus("Closed");
            Application.DoEvents();
        }
    }
}
