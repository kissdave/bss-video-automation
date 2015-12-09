using bss_video_automation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bss_video_automation
{

    class ContentGenerator
    {
        DateTime StartDate;
        DateTime EndDate;
        public List<PlaylistItem> PlaylistToCreate { get; set; }
        private List<Video> videos;
        private List<Video> videosWithoutPremiere;
        private List<Video> videosUse;
        public ContentGenerator(List<Video> videoList, DateTime start, DateTime end)
        {
            PlaylistToCreate = new List<PlaylistItem>();
            videos = videoList;
            StartDate = start;
            EndDate = end;
        }

        private void DeletePrimereVideos()
        {
            videosWithoutPremiere = videos.Where(x => x.DurationFrames != 0).ToList();
            List<PlaylistItem> temp;
            using (var context = new DBHandler())
            {
                temp = context.GetPlaylist(StartDate, EndDate);
            }
            foreach (PlaylistItem item in temp)
            {
                if (item.isPremiere || item.video.DurationFrames == 0)
                {
                    videosWithoutPremiere.Remove(item.video);
                }
            }
        }

        private DateTime GetLastWeekVideoEnd()
        {
            List<PlaylistItem> temp;
            using (var context = new DBHandler())
            {
                temp = context.GetPlaylist(StartDate.Subtract(new TimeSpan(1, 0, 0)), StartDate.Add(new TimeSpan(1, 0, 0)));
            }
            temp.Sort();
            if (temp.Count == 0)
            {
                return StartDate;
            }
            else
            {
                return temp.Last() != null ? temp.Last().EndTime : StartDate;
            }

        }

        private void AddRandomVideoToList(DateTime start)
        {
            if (videosUse == null || videosUse.Count == 0)
            {
                videosUse = videosWithoutPremiere.ToList();
            }
            Random rnd = new Random();
            int random = rnd.Next(0, videosUse.Count - 1);
            PlaylistToCreate.Add(new PlaylistItem(videosUse[random], start, false));
            videosUse.RemoveAt(random);
        }

        public void GenerateContentForWeek()
        {
            DeletePrimereVideos();
            videosUse = videosWithoutPremiere.ToList();
            while (PlaylistToCreate.Count == 0 || PlaylistToCreate.Last().StartTime < EndDate)
            {
                if (PlaylistToCreate.Count == 0)
                {
                    AddRandomVideoToList(GetLastWeekVideoEnd());
                }
                else
                {
                    AddRandomVideoToList(PlaylistToCreate.Last().EndTime);
                }

            }
            AddFixedItemsToList();
            PlaylistToCreate.Sort();
            DeleteOverlappingVideos();
            DeleteGeneratedContent(StartDate, EndDate, true);
            AddChangesToDB();
            Log.Logging.ErrorLog(Log.Logging.ErrorType.INFO, "Content generated for: " + StartDate.ToString() + " - " + EndDate.ToString());
        }

        private void DeleteOverlappingVideos()
        {
            foreach (PlaylistItem item in PlaylistToCreate.ToList())
            {
                if (item.isFixed)
                {
                    int indexOfItem = PlaylistToCreate.IndexOf(item);
                    if (indexOfItem > 0)
                    {
                        // Delete item before the fix video
                        if (PlaylistToCreate[indexOfItem - 1].StartTime < item.EndTime && item.StartTime < PlaylistToCreate[indexOfItem - 1].EndTime)
                        {
                            PlaylistToCreate.RemoveAt(indexOfItem - 1);
                        }
                        indexOfItem = PlaylistToCreate.IndexOf(item);
                        while (PlaylistToCreate[indexOfItem + 1].StartTime < item.EndTime && item.StartTime < PlaylistToCreate[indexOfItem + 1].EndTime)
                        {
                            PlaylistToCreate.RemoveAt(indexOfItem + 1);
                        }
                    }

                    FillBeforeAndAfterItem(item);
                }
            }
        }

        private void FillBeforeAndAfterItem(PlaylistItem item)
        {
            DateTime from;
            DateTime to;
            int indexOfItem = PlaylistToCreate.IndexOf(item);
            if (indexOfItem > 0)
            {
                from = PlaylistToCreate[indexOfItem - 1].EndTime;
                to = item.StartTime;
                FillGapBefore(from, to, item);
            }
            indexOfItem = PlaylistToCreate.IndexOf(item);
            if (indexOfItem > 0)
            {
                from = item.EndTime;
                to = PlaylistToCreate[indexOfItem + 1].StartTime;
                FillGapAfter(from, to, item);
            }

        }
        private void FillGapBefore(DateTime start, DateTime end, PlaylistItem item)
        {
            if ((end - start) < new TimeSpan(0, 2, 0))
            {
                AddContentBeforeGraphics(start, end, item);
                PlaylistToCreate.Sort();
            }
            else
            {
                videosUse = videosWithoutPremiere.Where(x => x.DurationTime <= (end - start)).ToList();
                if (videosUse.Count > 0)
                {
                    DateTime newEnd = start;
                    while (newEnd < end)
                    {
                        Random rnd = new Random();
                        int random = rnd.Next(0, videosUse.Count - 1);
                        Video videoToAdd = videosUse[random];
                        newEnd += videoToAdd.DurationTime;
                        if (newEnd > end)
                        {
                            newEnd -= videoToAdd.DurationTime;
                            break;
                        }
                        PlaylistToCreate.Add(new PlaylistItem(videoToAdd, start, false));
                        videosUse.RemoveAt(random);
                    }
                    AddContentBeforeGraphics(newEnd, end, item);
                }
            }
            PlaylistToCreate.Sort();
        }

        private void FillGapAfter(DateTime start, DateTime end, PlaylistItem item)
        {
            if ((end - start) < new TimeSpan(0, 1, 0))
            {
                List<PlaylistItem> itemsToCome = new List<PlaylistItem>();
                for (int i = PlaylistToCreate.IndexOf(item) + 1; (i < PlaylistToCreate.Count && i < PlaylistToCreate.IndexOf(item) + 4); i++)
                {
                    itemsToCome.Add(PlaylistToCreate[i]);
                }
                AddWhatsNextGraphics(start, end, itemsToCome);
                PlaylistToCreate.Sort();
            }
            else
            {
                videosUse = videosWithoutPremiere.Where(x => x.DurationTime <= (end - start)).ToList();
                if (videosUse.Count > 0)
                {
                    DateTime newStart = end;
                    while (newStart > start)
                    {
                        Random rnd = new Random();
                        int random = rnd.Next(0, videosUse.Count - 1);
                        Video videoToAdd = videosUse[random];
                        newStart -= videoToAdd.DurationTime;
                        if (newStart < start)
                        {
                            newStart += videoToAdd.DurationTime;
                            break;
                        }
                        PlaylistToCreate.Add(new PlaylistItem(videoToAdd, newStart, false));
                        videosUse.RemoveAt(random);
                    }
                    PlaylistToCreate.Sort();
                    List<PlaylistItem> itemsToCome = new List<PlaylistItem>();
                    for (int i = PlaylistToCreate.IndexOf(item) + 1; (i < PlaylistToCreate.Count && i < PlaylistToCreate.IndexOf(item) + 4); i++)
                    {
                        itemsToCome.Add(PlaylistToCreate[i]);
                    }
                    AddWhatsNextGraphics(start, newStart, itemsToCome);
                }
            }
            PlaylistToCreate.Sort();
        }

        private void AddWhatsNextGraphics(DateTime start, DateTime end, List<PlaylistItem> itemsToCome)
        {
            List<string> dataToPass = new List<string>();
            foreach (PlaylistItem item in itemsToCome)
            {
                dataToPass.Add(item.video.Title);
                dataToPass.Add(item.StartTime.ToString("HH:mm"));
            }
            PlaylistToCreate.Add(new PlaylistItem(new Graphics("comingUp", "Coming up...", dataToPass), start, end));

        }

        private void AddContentBeforeGraphics(DateTime start, DateTime end, PlaylistItem item)
        {
            if (item.isLive)
            {
                List<string> dataToPass = new List<string>();
                dataToPass.Add(item.StartTime.ToString());
                PlaylistToCreate.Add(new PlaylistItem(new Graphics("liveComing", "Live content coming: " + item.StartTime.ToString("HH:mm"), dataToPass), start, end));

            }
            else
            {
                List<string> dataToPass = new List<string>();
                dataToPass.Add(item.StartTime.ToString());
                PlaylistToCreate.Add(new PlaylistItem(new Graphics("scheduled", "Scheduled content coming: " + item.StartTime.ToString("HH:mm"), dataToPass), start, end));

            }
        }

        private void AddFixedItemsToList()
        {
            List<PlaylistItem> temp;
            using (var context = new DBHandler())
            {
                temp = context.GetPlaylist(StartDate, EndDate);
            }
            foreach (PlaylistItem item in temp)
            {
                if (item.isFixed)
                {
                    PlaylistToCreate.Add(item);
                }
            }
        }

        public static bool isContentGenerated(DateTime start, DateTime end)
        {
            List<PlaylistItem> temp;
            using (var context = new DBHandler())
            {
                temp = context.GetPlaylist(start, end);
            }
            foreach (PlaylistItem item in temp)
            {
                if (!item.isFixed)
                {
                    return true;
                }
            }
            return false;
        }

        public static void DeleteGeneratedContent(DateTime start, DateTime end, bool fixedAsWell)
        {
            using (var context = new DBHandler())
            {
                List<PlaylistItem> list = context.DBPlaylist.ToList();
                List<PlaylistItem> modifiedList = list.ToList();
                foreach (PlaylistItem item in list)
                {
                    if (!fixedAsWell || item.isFixed)
                    {
                        modifiedList.Remove(item);
                    }
                    if(item.StartTime < start || item.EndTime > end)
                    {
                        modifiedList.Remove(item);
                    }
                }
                foreach (PlaylistItem item in modifiedList)
                {
                    context.DeletePlaylistItem(item);
                }
            }
        }

        private void AddChangesToDB()
        {
            using (var context = new DBHandler())
            {
                foreach (PlaylistItem item in PlaylistToCreate)
                {
                    context.AddToPlaylist(item);
                }
                context.SaveChanges();
            }
        }
    }
}
