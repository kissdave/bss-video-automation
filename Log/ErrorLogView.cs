using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace bss_video_automation.Log
{
    public partial class ErrorLogView : Form
    {
        List<ErrorLogItem> errorLogitems;

        public ErrorLogView()
        {
            InitializeComponent();
            errorLogitems = new List<ErrorLogItem>();
            RefreshList();
            ErrorLogGridView.DataSource = errorLogitems;
        }

        public void RefreshList()
        {
            if (File.Exists(Logging.errorFile))
            {
                errorLogitems.Clear();
                using (StreamReader sr = new StreamReader(Logging.errorFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] components = line.Split('\t');
                        errorLogitems.Add(new ErrorLogItem(Logging.GetTypeFromString(components[0]), DateTime.ParseExact(components[1], "yyyy. MM. d. H:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture), components[2]));
                    }
                }
            }
        }

        private void ErrorLogGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (Logging.GetTypeFromString(ErrorLogGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                case Logging.ErrorType.INFO:
                    ErrorLogGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                    break;
                case Logging.ErrorType.WARNING:
                    ErrorLogGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    break;
                case Logging.ErrorType.ERROR:
                    ErrorLogGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    break;
            }
            if(e.ColumnIndex == 0)
            {
                ErrorLogGridView.Columns[e.ColumnIndex].Width = 100;
            }
            if (e.ColumnIndex == 1)
            {
                ErrorLogGridView.Columns[e.ColumnIndex].Width = 150;
            }
        }
    }
}
