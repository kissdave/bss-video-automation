using bss_video_automation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bss_video_automation
{
    public partial class AddScheduledVideo : Form
    {
        TimeSpan duration;
        public AddScheduledVideo()
        {
            InitializeComponent();
            duration = new TimeSpan(0);
            using (var context = new DBHandler())
            {
                cb_Video.DataSource = context.GetVideos();
                cb_Video.DropDownWidth = DropDownWidth(cb_Video) + 10;
            }
            UpdateLive();
        }

        private void UpdateLive()
        {
            if (!checkbox_Live.Checked)
            {
                dtpick_end.Enabled = false;
                tb_Duration_Hour.Enabled = false;
                tb_Duration_Minute.Enabled = false;
                tb_Duration_Second.Enabled = false;
                cb_Video.Enabled = true;
                cb_isPremiere.Enabled = true;
            }
            else
            {
                dtpick_end.Enabled = true;
                tb_Duration_Hour.Enabled = true;
                tb_Duration_Minute.Enabled = true;
                tb_Duration_Second.Enabled = true;
                cb_Video.Enabled = false;
                cb_isPremiere.Enabled = false;
            }
        }

        private void checkbox_Live_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLive();
        }

        private void dtpick_end_ValueChanged(object sender, EventArgs e)
        {
            duration = dtpick_end.Value - dtpick_start.Value;
            tb_Duration_Hour.Value = duration.Hours;
            tb_Duration_Minute.Value = duration.Minutes;
            tb_Duration_Second.Value = duration.Seconds;
        }



        private void UpdateEndTime()
        {
            if (checkbox_Live.Checked)
            {
                dtpick_end.Value = dtpick_start.Value.Add(new TimeSpan(Convert.ToInt32(tb_Duration_Hour.Value), Convert.ToInt32(tb_Duration_Minute.Value), Convert.ToInt32(tb_Duration_Second.Value)));
            }
            else
            {
                dtpick_end.Value = dtpick_start.Value.Add(((Video)cb_Video.SelectedItem).DurationTime);
            }
        }

        private void tb_Duration_Hour_ValueChanged(object sender, EventArgs e)
        {
            UpdateEndTime();
        }

        private void tb_Duration_Minute_ValueChanged(object sender, EventArgs e)
        {
            UpdateEndTime();
        }

        private void tb_Duration_Second_ValueChanged(object sender, EventArgs e)
        {
            UpdateEndTime();
        }

        private void dtpick_start_ValueChanged(object sender, EventArgs e)
        {
            UpdateEndTime();
        }
        int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in myCombo.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), myCombo.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            PlaylistItem item;
            if(checkbox_Live.Checked)
            {
                item = new PlaylistItem(dtpick_start.Value, dtpick_end.Value);
            } else
            {
                item = new PlaylistItem((Video)cb_Video.SelectedItem, dtpick_start.Value, true, cb_isPremiere.Checked);
            }
            using (var context = new DBHandler())
            {
                context.AddToPlaylist(item);
            }
            MessageBox.Show("Video added!", "Success!", MessageBoxButtons.OK);
            this.Dispose();
        }

        private void cb_Video_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEndTime();
        }
    }
}
