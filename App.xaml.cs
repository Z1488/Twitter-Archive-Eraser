using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Twitter_Archive_Eraser
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Useful for debugging binding issues:
            // See https://spin.atomicobject.com/2013/12/11/wpf-data-binding-debug/
            PresentationTraceSources.Refresh();
            PresentationTraceSources.DataBindingSource.Listeners.Add(new ConsoleTraceListener());
            PresentationTraceSources.DataBindingSource.Listeners.Add(new DebugTraceListener());
            PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Warning | SourceLevels.Error;
            base.OnStartup(e);
        }

        public class DebugTraceListener : TraceListener
        {
            public override void Write(string message)
            {
                Debugger.Break();
            }

            public override void WriteLine(string message)
            {
                Debugger.Break();
            }
        }
    }
}
