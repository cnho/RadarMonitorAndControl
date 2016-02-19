using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Common;

namespace RadarMonitorAndControl
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Log"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Log");
            }
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;
            string mName = Process.GetCurrentProcess().MainModule.ModuleName;
            string pName = Path.GetFileNameWithoutExtension(mName);
            Process[] myProcess = Process.GetProcessesByName(pName);
            if (myProcess.Length > 1)
            {
                MessageBox.Show(@"雷达状态监控程序已在运行！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
        
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            CommonLogHelper.GetInstance("LogFatal").Fatal($"\t未知致命错误{ex}");
            MessageBox.Show(ex.ToString());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;
            CommonLogHelper.GetInstance("LogFatal").Fatal($"\t线程致命错误{ex}");
            MessageBox.Show(ex.ToString());
        }
    }
}