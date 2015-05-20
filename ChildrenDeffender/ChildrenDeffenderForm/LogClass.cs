using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDeffenderForm
{
    class LogClass
    {

        TextWriterTraceListener EventLogger;
        TextWriterTraceListener ErrorLogger;

        // !! IMPORTANT !! - TRACE
        /*
        EventLogger = new TextWriterTraceListener("Events.log", "EventLog");
        ErrorLogger = new TextWriterTraceListener("Errors.log", "ErrorLog");
        EventLogger.WriteLine("#EventLog has been started.");
        EventLogger.WriteLine(DateTime.Now.ToString());
        EventLogger.Flush();
        */
        /*
        // EXAMPLE FOR TRACE
        TextWriterTraceListener myListener = new TextWriterTraceListener("TextWriterOutput.log", "myListener");
        myListener.WriteLine("Test message.");
        // You must close or flush the trace listener to empty the output buffer.
        myListener.Flush();
        */

        public LogClass ()
        {
            EventLogger = new TextWriterTraceListener("Events.log", "EventLog");
            ErrorLogger = new TextWriterTraceListener("Errors.log", "ErrorLog");

            SendEventLog("EventLog has been started.");
            SendErrorLog("ErrorLog has been started.");
            //EventLogger.WriteLine("#EventLog has been started.");
            //EventLogger.WriteLine(DateTime.Now.ToString());
            
        }

        public void SendEventLog(String text)
        {
            EventLogger.WriteLine(DateTime.Now.ToString() + "\t "+ text);
            EventLogger.Flush();
            Console.WriteLine(text);
        }

        public void SendErrorLog(String text)
        {
            ErrorLogger.WriteLine(DateTime.Now.ToString() + "\t " + text);
            ErrorLogger.Flush();
            Console.WriteLine(text);
        }


    }
}
