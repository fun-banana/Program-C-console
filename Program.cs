using System;
using System.Diagnostics;

namespace Programs_controller_console
{
    class Program
    {
        static string testProgramPath = @"D:\GitHub\ddos\bin\Debug\net5.0\ddos.exe";

        static void Main(string[] args)
        {
            Process[] allProccess = Process.GetProcesses();

            // foreach (Process currentProcess in allProccess)
            // {
            //     Console.Write($"{currentProcess.Id}\t\t{currentProcess.ProcessName}");
            //     Console.WriteLine();
            // }

            ProcessInfo testProcess = new ProcessInfo("ddos", testProgramPath);
            testProcess.SaveAsJson("temp");
            testProcess.StartProcess();
        }
    }
}
