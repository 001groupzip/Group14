using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Proc
{
    class Program
    {
        static void Main(string[] args)
        {
            //StartProcesses();

            //ShowKill(processes);

            //ShowProcInfo(processes);
        }

        private static void StartProcesses()
        {
            Process[] processes = Process.GetProcesses();

            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "notepad++";
            info.Arguments = @"C:\Lesson6\Point.txt";
            info.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(info);

            Process.Start("notepad++", @"C:\Lesson6\Point.txt");
            Process.Start("chrome", @"http:\\google.com");
        }

        private static void ShowKill(Process[] processes)
        {
            foreach (Process item in processes)
            {
                if (item.ProcessName == "notepad++")
                {
                    Console.WriteLine("Процесс закрыт");
                    item.Kill();
                }
            }
        }

        private static void ShowProcInfo(Process[] processes)
        {
            foreach (Process item in processes)
            {
                Console.WriteLine(item.ProcessName);
                Console.WriteLine(item.PeakPagedMemorySize64);
                try { Console.WriteLine(item.StartTime); }
                catch { }

                Console.WriteLine();
            }
        }
    }
}
