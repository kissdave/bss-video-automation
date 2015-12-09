using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svt.Caspar;
using Svt.Network;

namespace bss_video_automation
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            tb_CasparServerAddress.Text = Properties.Settings.Default.CasparCG_ServerAddress;
            tb_CasparServerPort.Text = Properties.Settings.Default.CasparCG_ServerPort.ToString();
            tb_CasparChannel.Text = Properties.Settings.Default.CasparCG_Channel.ToString();
            tb_LogoSrc.Text = Properties.Settings.Default.CasparCG_LogoSrc;
        }

        private void btn_TestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (Playout.Instance.testConnection(tb_CasparServerAddress.Text, Convert.ToInt32(tb_CasparServerPort.Text)))
                {
                    lb_TestResult.Text = "Success";
                }
                else
                {
                    lb_TestResult.Text = "Error";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CasparCG_ServerAddress = tb_CasparServerAddress.Text;
            Properties.Settings.Default.CasparCG_ServerPort = Convert.ToInt32(tb_CasparServerPort.Text);
            Properties.Settings.Default.CasparCG_Channel = Convert.ToInt32(tb_CasparChannel.Value);
            Properties.Settings.Default.CasparCG_LogoSrc = tb_LogoSrc.Text;
            Properties.Settings.Default.Save();

        }
    }
}
