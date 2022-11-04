using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1103
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            TextWriterTraceListener tw = new TextWriterTraceListener("mylog.log");
            Trace.Listeners.Add(tw);
            
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //throw new NotImplementedException();
            Trace.WriteLine($@"錯誤訊息:{(e.ExceptionObject as Exception).Message},發生時間:{DateTime.Now},執行者:{Environment.UserName}");
            Trace.Flush();

        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //throw new NotImplementedException();
            Trace.WriteLine($@"錯誤訊息:{e.Exception.Message},發生時間:{DateTime.Now},執行者:{Environment.UserName}");
            Trace.Flush();
        }
    }
}
