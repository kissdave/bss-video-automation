using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bss_video_automation.Log;

namespace bss_video_automation.Exceptions
{
    class MediaNotFoundException : Exception
    {
        public MediaNotFoundException()
        {
            Logging.ErrorLog(Logging.ErrorType.ERROR, "Media not found");
        }
        public MediaNotFoundException(string message)
            : base(message)
        {
            Logging.ErrorLog(Logging.ErrorType.ERROR, "Media not found");
        }

        public MediaNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
            Logging.ErrorLog(Logging.ErrorType.ERROR, "Media not found");
        }


    }
}
