using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bss_video_automation.Log
{
    public static class Logging
    {
        public enum ErrorType { INFO, WARNING, ERROR };
        public static string errorFile = "error.log";
        public static string videoFile = "video.log";

        public static void ErrorLog(ErrorType type, DateTime time, string message)
        {

            using (StreamWriter sw = File.AppendText(errorFile))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(GetStringFromType(type));
                sb.Append("\t");
                sb.Append(time.ToString("yyyy. MM. d. H:mm:ss.fff"));
                sb.Append("\t");
                sb.Append(message);
                sw.WriteLine(sb.ToString());
            }
        }
        public static void ErrorLog(ErrorType type, string message)
        {
            ErrorLog(type, DateTime.Now, message);
        }

        public static void VideoLog(string id, string filename)
        {
            using (StreamWriter sw = File.AppendText(videoFile))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(DateTime.Now.ToString("yyyy. MM. d. H:mm:ss.fff"));
                sb.Append("\t");
                sb.Append(id);
                sb.Append("\t");
                sb.Append(filename);
                sw.WriteLine(sb.ToString());
            }
        }

        public static string GetStringFromType(ErrorType type)
        {
            switch (type)
            {
                case ErrorType.INFO:
                    return "INFO";

                case ErrorType.WARNING:
                   return "WARNING";

                case ErrorType.ERROR:
                    return "ERROR";

                default:
                    return "";
            }
        }
        public static ErrorType GetTypeFromString(string type)
        {
            switch (type)
            {
                case "INFO":
                    return ErrorType.INFO;

                case "WARNING":
                    return ErrorType.WARNING;

                case "ERROR":
                    return ErrorType.ERROR;

                default:
                    return ErrorType.INFO;
            }
        }
    }

}
