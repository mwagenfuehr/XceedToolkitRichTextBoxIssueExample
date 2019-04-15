using System;
using System.Diagnostics;
using System.IO;


// ReSharper disable once IdentifierTypo
namespace Example01.UsingXceedRtbWithoutFormatter
{
    internal static class Program
    {
        [STAThread]
        public static int Main(string[] args)
        {
            AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) =>
            {
                Trace.TraceError(eventArgs.Exception.ToString());
                File.AppendAllText("output.log", eventArgs.Exception.ToString() + Environment.NewLine);
            };
            
            return new App().Run(new MainWindow());
        }
    }
}