using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bss_video_automation.Model
{
    public class Graphics
    {
        public int GraphicsID { get; set; }
        public string templateFilename { get; set; }
        public string Title { get; set; }
        public List<string> Data { get; set; }

        public Graphics(string templateFilename, string Title, List<string> data)
        {
            this.templateFilename = templateFilename;
            this.Title = Title;
            this.Data = data;
        }

        public override string ToString()
        {
            return Title + " ( " + templateFilename + " ) "; 
        }
    }
}
