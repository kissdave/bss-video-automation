using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bss_video_automation.Log;
using bss_video_automation.Model;
using System.Threading;

namespace bss_video_automation
{
    public partial class MainForm : Form
    {

        private List<PlaylistItem> playlist;

        public List<PlaylistItem> Playlist
        {
            get { return playlist; }
            set { playlist = value; }
        }

        private Player player;

        public MainForm()
        {
            InitializeComponent();
            Logging.ErrorLog(Logging.ErrorType.INFO, "Software started");

            /* ----- Init Playlist ----- */
            playlist = new List<PlaylistItem>();

            // Create a list of avaliable videos
            //List<Video> videos = new List<Video>();
            //videos.Add(new Video("20151006_qpa_schoszkar_hq_HD", new TimeSpan((long)2199 * 400000), 2199, "QPA - Schoszkár", new DateTime(2015, 10, 6), "Sgánetz Bence", 4.8, new Category("QPA")));
            //videos.Add(new Video("20151010_qpa_osszefoglalo_hq_HD", new TimeSpan((long)3171 * 400000), 3171, "QPA - Összefoglaló", new DateTime(2015, 10, 10), "Barlangi Ákos, Kiss Dávid", 3.9, new Category("QPA")));
            //videos.Add(new Video("20151105_Daki_interju_hq_HD", new TimeSpan((long)7579 * 400000), 7579, "Interjú Daku Dávid EHK elnökkel", new DateTime(2015, 11, 5), "Garai Gábor, Csupity László, Ulveczky Mihály, Vizi Andrea", 4.5, new Category("EHK")));
            //videos.Add(new Video("20151028_nyamm_sutotok_hq_HD", new TimeSpan((long)8085 * 400000), 8085, "Nyamm, Sütőtök", new DateTime(2015, 10, 28), "Grób Csaba", 4.8, new Category("NYAMM")));

            //playlist.Add(new PlaylistItem(videos[0], new DateTime(2015, 11, 21, 11, 15, 00, 0), false));
            //playlist.Add(new PlaylistItem(videos[1], playlist[playlist.Count - 1].StartTime + new TimeSpan(0, 0, 10), false));
            //playlist.Add(new PlaylistItem(videos[2], playlist[playlist.Count - 1].EndTime, false));
            //playlist.Add(new PlaylistItem(videos[3], playlist[playlist.Count - 1].EndTime, false));

            StartPlaylistUpdateThread();

            player = new Player(this);
            player.PlayerStateChanged += Player_PlayerStateChanged;
            Playout.Instance.ServerStatusChanged += Instance_ServerStatusChanged;
            
            lb_status.Text = "Disconnected from server";
            mainStatusStrip.BackColor = Color.Red;

            listBox_playlist.DataSource = playlist;
        }

        public void RefreshList()
        {
            listBox_playlist.DataSource = null;
            listBox_playlist.Refresh();
            listBox_playlist.DataSource = playlist;
            listBox_playlist.Invalidate();
        }

        private void Player_PlayerStateChanged(object sender, EventArgs e)
        {
            if (Playout.Instance.ServerConnected && player.isPlaying)
            {
                if (InvokeRequired)
                {
                    Invoke(new ChangedStatusLabelDelegate(ChangeStatusLabel), new object[] { "Connected to server | Playing..." });
                }
                else
                {
                    lb_status.Text = "Connected to server | Playing..";
                }
                mainStatusStrip.BackColor = Color.Green;
            }
            if (Playout.Instance.ServerConnected && !player.isPlaying)
            {
                if (InvokeRequired)
                {
                    Invoke(new ChangedStatusLabelDelegate(ChangeStatusLabel), new object[] { "Connected to server | Stopped" });
                }
                else
                {
                    lb_status.Text = "Connected to server | Stopped";
                }
                mainStatusStrip.BackColor = Color.Orange;
            }
        }

        private delegate void ChangedStatusLabelDelegate(string text);

        private void Instance_ServerStatusChanged(object sender, EventArgs e)
        {
            if (Playout.Instance.ServerConnected)
            {
                if(InvokeRequired)
                {
                    Invoke(new ChangedStatusLabelDelegate(ChangeStatusLabel), new object[] { "Connected to server" });
                } else
                {
                    lb_status.Text = "Connected to server";
                }
                mainStatusStrip.BackColor = Color.Orange;
            } else {
                player.Stop();
                if (InvokeRequired)
                {
                    Invoke(new ChangedStatusLabelDelegate(ChangeStatusLabel), new object[] { "Disconnected from server" });
                }
                else
                {
                    lb_status.Text = "Disconnected from server";
                }
                lb_status.Text = "Disconnected from server";
                mainStatusStrip.BackColor = Color.Red;
            }
        }

        public void ChangeStatusLabel(string msg)
        {
            lb_status.Text = msg;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Are you sure to close the program?!", "It must run 24/7", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                Playout.Instance.Disconnect();
                e.Cancel = false;
                Logging.ErrorLog(Logging.ErrorType.WARNING, "Software terminated");
            } else
            {
                e.Cancel = true;
            }
        }

        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.TimeOfDay.ToString();
            lb_clock.Text = time.Split('.')[0];
        }

        private void btn_Player_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Playout.Instance.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Player_Disconnect_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure to disconnect from server?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                Playout.Instance.Disconnect();
            }
        }

        private void btn_Player_Start_Click(object sender, EventArgs e)
        {
            if(Playout.Instance.ServerConnected)
            {
                player.Start();
            }
            else
            {
                MessageBox.Show("The client is disconnected from server!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Player_Stop_Click(object sender, EventArgs e)
        {
            if(Playout.Instance.ServerConnected || player.isPlaying ) { 
                if ((MessageBox.Show("Are you sure to stop the playout?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
                {
                    player.Stop();
                }
            }
            else
            {
                MessageBox.Show("The client is disconnected from server or no playback is in progress!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void errorLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorLogView errorLogView = new ErrorLogView();
            errorLogView.Show();
        }

        public void DisplayMessagebox(string text)
        {
            MessageBox.Show(text, "INFO", MessageBoxButtons.OK);
        }

        private void StartPlaylistUpdateThread()
        {
            Thread t = new Thread(new ThreadStart(UpdatePlaylistFromDB));
            t.IsBackground = true;
            t.Start();
        }

        private delegate void UpdateList();

        private void UpdatePlaylistFromDB()
        {
            while (true)
            {
                using (var context = new DBHandler())
                {
                    playlist = context.GetPlaylist48();
                    Log.Logging.ErrorLog(Logging.ErrorType.INFO, "Playlist updated from database");
                    if (InvokeRequired)
                    {
                        Invoke(new UpdateList(RefreshList));
                    }
                    else
                    {
                        RefreshList();
                    }
                }
                Thread.Sleep(new TimeSpan(0, 1, 0));
            }
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorForm editorForm = new EditorForm();
            editorForm.Show();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
