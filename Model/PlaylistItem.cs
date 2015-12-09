using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bss_video_automation.Model
{
    public class PlaylistItem : IComparable
    {
        public int PlaylistItemID { get; set; }
        public virtual Video video { get; set; }
        public virtual Graphics graphics { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool isFixed { get; set; }
        public bool isEdited { get; set; }
        public bool isPremiere { get; set; }
        public bool isLive { get; set; }
        public bool isGraphics { get; set; }

        public PlaylistItem()
        {

        }

        public PlaylistItem(Graphics graphics, DateTime start, DateTime end)
        {
            var db = new DBHandler();
            this.video = db.emergency;
            this.graphics = graphics;
            this.StartTime = start;
            this.EndTime = end;
            this.isFixed = false;
            this.isEdited = false;
            this.isPremiere = false;
            this.isLive = false;
            this.isGraphics = true;
        }

        public PlaylistItem(Video video, DateTime start, bool fix)
        {
            this.video = video;
            StartTime = start;
            EndTime = (video != null) ? start + video.DurationTime : start;
            this.isFixed = fix;
            this.isLive = false;
        }

        public PlaylistItem(Video video, DateTime start, bool fix, bool premiere)
        {
            this.video = video;
            StartTime = start;
            EndTime = (video != null) ? start + video.DurationTime : start;
            this.isFixed = fix;
            this.isLive = false;
            this.isPremiere = true;
        }

        public PlaylistItem(DateTime start, DateTime end)
        {
            var db = new DBHandler();
            this.StartTime = start;
            this.EndTime = end;
            this.video = db.emergency;
            this.isFixed = true;
            this.isLive = true;
            this.isPremiere = false;
        }

        public int CompareTo(object obj)
        {
            PlaylistItem parsed = (PlaylistItem)obj;
            return StartTime.CompareTo(parsed.StartTime);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.StartTime);
            sb.Append("\t");
            sb.Append(this.EndTime);
            sb.Append("\t");
            if (!this.isGraphics)
            {
                if (this.video != null)
                    sb.Append(this.video.Filename);
                else
                    sb.Append("No video");
            }
            else if(this.graphics != null)
            {
                sb.Append(this.graphics.Title);
            }
            return sb.ToString();
        }
    }
}
