using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;
using bss_video_automation.Model;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Infrastructure;

namespace bss_video_automation
{
    class DBHandler : DbContext
    {
        public DbSet<PlaylistItem> DBPlaylist { get; set; }
        public DbSet<Video> DBVideos { get; set; }

        public Video emergency;
        public DBHandler() : base(bss_video_automation.Properties.Settings.Default.bss_video_automationConnectionString)
        {
            emergency = (Video)DBVideos.Where(x => x.Filename == "EMERGENCY").ToList()[0];
        }

        public List<Video> GetVideos()
        {
            return DBVideos.ToList();
        }

        public List<PlaylistItem> GetPlaylist48()
        {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now + new TimeSpan(2, 0, 0, 0);
            this.Configuration.LazyLoadingEnabled = false;
            List<PlaylistItem> result = new List<PlaylistItem>(DBPlaylist.Where(x => (DbFunctions.DiffSeconds(x.EndTime, start) < 0) && (DbFunctions.DiffSeconds(x.EndTime, end) > 0)).Include(x => x.video).ToList());
            result.Sort();
            return result;
        }
        public List<PlaylistItem> GetPlaylist(DateTime start, DateTime end)
        {
            this.Configuration.LazyLoadingEnabled = false;
            List<PlaylistItem> result = new List<PlaylistItem>(DBPlaylist.Where(x => (DbFunctions.DiffSeconds(x.StartTime, start) < 0) && (DbFunctions.DiffSeconds(x.EndTime, end) > 0)).Include(x => x.video).ToList());
            result.Sort();
            return result;
        }

        public void DBAddVideo(Video video)
        {
            this.DBVideos.Add(video);
            this.SaveChanges();
        }

        public void AddToPlaylist(PlaylistItem item)
        {
            Video existingVideo = (from v in this.DBVideos where v.VideoID == item.video.VideoID select v).FirstOrDefault();
            item.video = existingVideo;
            this.Entry(item.video).State = EntityState.Unchanged;
            DBPlaylist.Add(item);
            //DBVideos.Attach(item.video);

            this.SaveChanges();
        }

        public void DeletePlaylistItem(PlaylistItem dataBoundItem)
        {
            DBPlaylist.Remove(dataBoundItem);
            this.SaveChanges();
        }
    }
}
