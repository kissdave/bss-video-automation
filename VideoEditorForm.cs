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
    public partial class VideoEditorForm : Form
    {
        public VideoEditorForm()
        {
            InitializeComponent();
        }

        private void VideoEditorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bss_video_automationDataSet.Videos' table. You can move, or remove it, as needed.
            this.videosTableAdapter.Fill(this.bss_video_automationDataSet.Videos);

        }

        private void btn_AddVideo_Click(object sender, EventArgs e)
        {
            AddVideoForm addvideoform = new AddVideoForm();
            addvideoform.ShowDialog();
        }

        private void btn_RefreshList_Click(object sender, EventArgs e)
        {
            videosBindingSource.DataSource = bss_video_automationDataSet;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = videosBindingSource;
            dataGridView1.Refresh();
        }
    }
}
