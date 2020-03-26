// Copyright @Internship2020

namespace netFundamentals.Logging
{
    using System.Diagnostics;
    using Interfaces;
    
    internal class Logger : ILogger
    {
        public void Log(string logMessage)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("logs.log"));
            Trace.AutoFlush = true;
            Trace.Indent();
            Trace.WriteLine(logMessage);
            Trace.Unindent();
        }
    }
}
