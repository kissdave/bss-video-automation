using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bss_video_automation.Log;
using System.Windows.Forms;
using System.Threading;
using bss_video_automation.Model;
using System.ComponentModel;

namespace bss_video_automation
{
    public delegate void PlayerStateChangedDelegate(Object sender, EventArgs e);


    /**
    This class is the player, it runs in a background thread and plays the videos according to the schedule
    */
    public class Player
    {
        private delegate void DisplayMessage(string text);

        private bool isplaying;
        public bool isPlaying
        {
            get { return isplaying; }
        }

        public event PlayerStateChangedDelegate PlayerStateChanged;

        private MainForm context;

        public Player(MainForm parentForm)
        {
            isplaying = false;
            context = parentForm;
        }

        public void Start()
        {
            if (!isplaying)
            {
                isplaying = true;
                PlayerStateChanged(this, EventArgs.Empty);

                context.Playlist.Add(new PlaylistItem(null, new DateTime(1992, 1, 1), false));
                context.Playlist.Sort();

                Thread t = new Thread(new ThreadStart(Play));
                t.IsBackground = true;
                t.Start();

                Logging.ErrorLog(Logging.ErrorType.INFO, DateTime.Now, "Playout started");
            }
        }
        private delegate void UpdateGUI();

        public void Play()
        {
            while (isplaying)
            {
                if ((context.Playlist.Count > 1) && (context.Playlist[1].StartTime - DateTime.Now).TotalMilliseconds < 20)
                {
                    if (context.Playlist[1].graphics == null)
                    {
                        Playout.Instance.PlayVideo("PLAYOUT\\" + context.Playlist[1].video.Filename);
                    } else
                    {
                        if(context.Playlist[1].isGraphics == true && context.Playlist[2].isLive)
                        {
                            Playout.Instance.LiveComing(context.Playlist[1].graphics.Data[0]);
                        }
                        else if(context.Playlist[1].isGraphics == true && !context.Playlist[2].isLive)
                        {
                            Playout.Instance.ShowWhatsNext(context.Playlist[1].graphics.Data);
                        }
                    }
                    Log.Logging.VideoLog(context.Playlist[0].PlaylistItemID.ToString(), context.Playlist[0].ToString());
                    context.Playlist.RemoveAt(0);
                    
                    if (context.InvokeRequired)
                    {
                        context.Invoke(new UpdateGUI(context.RefreshList));
                    }
                    else
                    {
                        context.RefreshList();
                    }
                }
                Thread.Sleep(new TimeSpan(0, 0, 0, 0, 15));
            }
        }

        public void Stop()
        {
            if (isplaying)
            {
                isplaying = false;
                PlayerStateChanged(this, EventArgs.Empty);
                Logging.ErrorLog(Logging.ErrorType.WARNING, DateTime.Now, "Playout stopped");
            }
        }


    }
}
