using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bss_video_automation.Log
{
    public class ErrorLogItem
    {
        private Logging.ErrorType type;

        public Logging.ErrorType Type
        {
            get { return type; }
        }

        private DateTime time;

        public DateTime Time
        {
            get { return time; }
        }

        private string message;

        public string Message
        {
            get { return message; }
        }

        public ErrorLogItem(Logging.ErrorType type, DateTime time, string message)
        {
            this.type = type;
            this.time = time;
            this.message = message;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Logging.GetStringFromType(type));
            sb.Append("\t");
            sb.Append(time.ToString("yyyy. MM. d. H:mm:ss.fff"));
            sb.Append("\t");
            sb.Append(message);
            return sb.ToString();
        }
    }
}
