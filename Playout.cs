using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svt.Caspar;
using Svt.Caspar.Controls;
using Svt.Network;
using bss_video_automation.Exceptions;
using bss_video_automation.Log;
using System.Threading;
using System.Net.Sockets;

namespace bss_video_automation
{
    public delegate void ChangedServerStatus(Object sender, EventArgs e);
    public class Playout
    {
        private CasparDevice casparDevice;

        private bool serverConnected;

        public bool ServerConnected
        {
            get { return serverConnected; }
        }

        // ----------- Events ----------- 

        public event ChangedServerStatus ServerStatusChanged;

        private static Playout instance;
        public static Playout Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Playout();
                }
                return instance;
            }
        }
        private Playout()
        {
            casparDevice = new CasparDevice();
            casparDevice.ConnectionStatusChanged += CasparDevice_ConnectionStatusChanged;
        }

        protected void ChangeServerStatus(EventArgs e)
        {
            ServerStatusChanged(this, e);
        }

        private void CasparDevice_ConnectionStatusChanged(object sender, ConnectionEventArgs e)
        {
            serverConnected = casparDevice.IsConnected;
            ChangeServerStatus(EventArgs.Empty);
            if (serverConnected)
            {
                casparDevice.RefreshDatalist();
                casparDevice.RefreshMediafiles();
                casparDevice.RefreshTemplates();
                Logging.ErrorLog(Logging.ErrorType.INFO, "Connected to server");
            }
            else
            {
                Logging.ErrorLog(Logging.ErrorType.ERROR, "Disconnected from server");
            }
        }

        /**
        Connects to the CasparServer with address and port
        */
        public void Connect()
        {
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {


                    if (!(Properties.Settings.Default.CasparCG_ServerAddress.Equals(null) &&
        Properties.Settings.Default.CasparCG_ServerPort.Equals(null) &&
        Properties.Settings.Default.CasparCG_Channel.Equals(null)))
                    {
                        if (!(Properties.Settings.Default.CasparCG_ServerAddress.Equals("") &&
                            Properties.Settings.Default.CasparCG_ServerPort.Equals(0) &&
                            Properties.Settings.Default.CasparCG_Channel.Equals(0)))
                        {
                            socket.Connect(Properties.Settings.Default.CasparCG_ServerAddress, Properties.Settings.Default.CasparCG_ServerPort);
                            socket.Disconnect(false);
                            casparDevice.Connect(Properties.Settings.Default.CasparCG_ServerAddress, Properties.Settings.Default.CasparCG_ServerPort);
                        }
                    }
                }
                catch (SocketException ex)
                {
                    Logging.ErrorLog(Logging.ErrorType.ERROR, "Server not avaliable, " + ex.Message);
                    throw ex;
                }
            }
        }

        public void Disconnect()
        {
            casparDevice.Disconnect();
        }

        public bool IsMediaExists(string filename)
        {
            bool found = false;
            casparDevice.RefreshMediafiles();
            foreach (MediaInfo item in casparDevice.Mediafiles)
            {
                if (item.FullName.Equals(filename.ToUpper()))
                {
                    found = true;
                }
            }
            return found;
        }

        /**
        Play a video on the default channel of CasparServer
        Video is on videoLayer 20
        */
        public void PlayVideo(string filename)
        {
            bool fileFound = IsMediaExists(filename);

            if (fileFound)
            {
                casparDevice.Channels[Properties.Settings.Default.CasparCG_Channel - 1].Load(20, filename, false);
                casparDevice.Channels[Properties.Settings.Default.CasparCG_Channel - 1].Play(20);
            }
            else
            {
                throw new MediaNotFoundException();
            }
        }

        public void GetRemainingTime()
        {
            // TODO Implement this
            throw new NotImplementedException();
        }

        /**
        Changes the logo state to the parameter
        Logo is on videolayer 100
        */
        public void PutLogo(bool onOff)
        {
            if (IsMediaExists(Properties.Settings.Default.CasparCG_LogoSrc))
            {
                if (onOff)
                {
                    casparDevice.Channels[Properties.Settings.Default.CasparCG_Channel - 1].Load(100, Properties.Settings.Default.CasparCG_LogoSrc, false);
                    casparDevice.Channels[Properties.Settings.Default.CasparCG_Channel - 1].Play();
                }
            }
        }




        public bool testConnection(string ServerAddress, int ServerPort)
        {
            CasparDevice cd = new CasparDevice();
            cd.Connect(ServerAddress, ServerPort);
            Thread.Sleep(1000);
            if (cd.IsConnected)
            {
                cd.Disconnect();
                return true;
            }
            else
            {
                cd.Disconnect();
                return false;
            }

        }

        public List<MediaInfo> GetAvailableMedia()
        {
            casparDevice.RefreshMediafiles();
            return casparDevice.Mediafiles;
        }

        public void ShowWhatsNext(List<String> data)
        {
            //casparDevice.Channels[Properties.Settings.Default.CasparCG_Channel - 1].CG.Add();
        }

        public void LiveComing(string Title)
        {
            //casparDevice.Channels[Properties.Settings.Default.CasparCG_Channel - 1].CG.Add();
        }
    }
}
