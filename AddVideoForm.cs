using bss_video_automation.Model;
using Svt.Caspar;
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
    public partial class AddVideoForm : Form
    {
        public AddVideoForm()
        {
            InitializeComponent();
            cb_Filename.DataSource = Playout.Instance.GetAvailableMedia();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DBHandler())
                {
                    MediaInfo tempMedia = (MediaInfo)cb_Filename.SelectedItem;
                    Video temp = new Video(tempMedia.Name, new TimeSpan(Convert.ToInt64(tb_Duration.Text) * 400000), Convert.ToInt32(tb_Duration.Text), tb_Title.Text, cal_Date.SelectionStart, tb_Contributors.Text, Convert.ToDouble(tb_Rating.Value), " ");
                    context.DBAddVideo(temp);
                }
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
