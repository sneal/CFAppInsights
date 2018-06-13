using System;
using System.Diagnostics;
using System.Text;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;

namespace CFWebApplicationMvc
{
    public class TelemetryChannel : ITelemetryChannel
    {
        public TelemetryChannel()
        {
            Trace.WriteLine("TelemetryChannel ctor");
        }

        public bool? DeveloperMode
        {
            get { return true; }
            set { }
        }

        public string EndpointAddress
        {
            get { return ""; }
            set { }
        }

        public void Dispose()
        {
            
        }

        public void Flush()
        {
            
        }

        public void Send(ITelemetry item)
        {
            item.Sanitize();
            var b = JsonSerializer.Serialize(new ITelemetry[] { item }, false);
            var s = Encoding.UTF8.GetString(b);
            Trace.WriteLine(string.Format("AI: {0}", s));
        }
    }
}