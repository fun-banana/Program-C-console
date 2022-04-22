using System;
using System.Diagnostics;

namespace Programs_controller_console
{
    class Program
    {
        static string testProgramPath = @"C:\Users\tarno\Downloads\AxureRP-Setup.exe";

        static void Main(string[] args)
        {
            Process[] allProccess = Process.GetProcesses();

            // foreach (Process currentProcess in allProccess)
            // {
            //     Console.Write($"{currentProcess.Id}\t\t{currentProcess.ProcessName}");
            //     Console.WriteLine();
            // }

            ProcessInfo testProcess = new ProcessInfoCmd("ddos", testProgramPath);
            testProcess.SaveAsJson("temp");
            testProcess.StartProcess();
        }
    }
}
