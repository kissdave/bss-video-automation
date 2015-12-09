using bss_video_automation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bss_video_automation
{
    public partial class EditorForm : Form
    {
        List<PlaylistItem> list;
        public EditorForm()
        {
            InitializeComponent();
            list = new List<PlaylistItem>();
            cb_Year.SelectedItem = DateTime.Now.Year.ToString();

        }

        private void btn_manageVideos_Click(object sender, EventArgs e)
        {
            VideoEditorForm videoEditorForm = new VideoEditorForm();
            videoEditorForm.Show();
        }

        private void cb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            var jan1 = new DateTime(Convert.ToInt32(cb_Year.SelectedItem), 1, 1);
            //beware different cultures, see other answers
            var startOfFirstWeek = jan1.AddDays(1 - (int)(jan1.DayOfWeek));
            var weeks =
                Enumerable
                    .Range(0, 54)
                    .Select(i => new
                    {
                        weekStart = startOfFirstWeek.AddDays(i * 7)
                    })
                    .TakeWhile(x => x.weekStart.Year <= jan1.Year)
                    .Select(x => new
                    {
                        x.weekStart,
                        weekFinish = x.weekStart.AddDays(4)
                    })
                    .SkipWhile(x => x.weekFinish < jan1.AddDays(1))
                    .Select((x, i) => new
                    {
                        x.weekStart,
                        x.weekFinish,
                        weekNum = i + 1
                    });
            List<MyWeek> weeksOfYear = new List<MyWeek>();
            foreach (var item in weeks)
            {
                weeksOfYear.Add(new MyWeek(item.weekStart, item.weekFinish, item.weekNum));
            }
            for (int i = 0; i < weeksOfYear.Count() - 1; i++)
            {
                weeksOfYear[i].WeekEnd = weeksOfYear[i + 1].WeekStart - (new TimeSpan(0, 0, 0, 1));
            }
            cb_Week.DataSource = weeksOfYear;
            if (DateTime.Now.Year == Convert.ToInt32(cb_Year.SelectedItem))
            {
                var currentCulture = CultureInfo.CurrentCulture;
                int weekNo = currentCulture.Calendar.GetWeekOfYear(
                                DateTime.Now,
                                currentCulture.DateTimeFormat.CalendarWeekRule,
                                currentCulture.DateTimeFormat.FirstDayOfWeek);
                cb_Week.SelectedIndex = weekNo - 1;
            }
        }

        private class MyWeek
        {
            public DateTime WeekStart { get; set; }
            public DateTime WeekEnd { get; set; }
            public int WeekNum { get; set; }
            public MyWeek(DateTime start, DateTime end, int num)
            {
                this.WeekStart = start;
                this.WeekEnd = end;
                this.WeekNum = num;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(WeekNum.ToString());
                sb.Append(". (");
                sb.Append(WeekStart.ToString());
                sb.Append(" - ");
                sb.Append(WeekEnd.ToString());
                sb.Append(")");
                return sb.ToString();
            }
        }

        private void cb_Week_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyWeek selected = (MyWeek)cb_Week.SelectedItem;
            using (var context = new DBHandler())
            {
                list.Clear();
                dataGrid_list.DataSource = list;
                list = context.GetPlaylist(selected.WeekStart, selected.WeekEnd);
                dataGrid_list.DataSource = list.Select(x => new { StartTime = x.StartTime, EndTime = x.EndTime, Video = (x.video != null ? (x.video.Title + "(" + x.video.Filename + ")") : ""), IsFixed = x.isFixed, IsLive = x.isLive }).ToList();
            }
        }

        private void btn_AddScheduledVideo_Click(object sender, EventArgs e)
        {
            AddScheduledVideo addScheduledVideo = new AddScheduledVideo();
            addScheduledVideo.ShowDialog();
        }

        private void dataGrid_list_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                                 "Confirm Delete!",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (var context = new DBHandler())
                {
                    context.DeletePlaylistItem(((PlaylistItem)e.Row.DataBoundItem));
                }
            }

        }

        private void btn_GenerateContent_Click(object sender, EventArgs e)
        {

            try
            {
                List<Video> videos;
                MyWeek selected = (MyWeek)cb_Week.SelectedItem;
                using (var context = new DBHandler())
                {
                    videos = context.GetVideos();
                }
                ContentGenerator contentGenerator = new ContentGenerator(videos, selected.WeekStart, selected.WeekEnd);
                // Check if content is generated for the week
                if (ContentGenerator.isContentGenerated(selected.WeekStart, selected.WeekEnd))
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete already created items?",
                                                     "Confirm Delete!",
                                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.No)
                    {
                        return;
                    }
                    ContentGenerator.DeleteGeneratedContent(selected.WeekStart, selected.WeekEnd, false);
                }
                Cursor.Current = Cursors.WaitCursor;
                contentGenerator.GenerateContentForWeek();
                cb_Week.SelectedIndex += 1;
                cb_Week.SelectedIndex -= 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Arrow;
            }
        }

        private void btn_DeleteGenerated_Click(object sender, EventArgs e)
        {
        }
    }
}
