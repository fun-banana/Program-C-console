using System.Diagnostics;

class ProcessInfoCmd : ProcessInfo
{
    public ProcessInfoCmd(string name, string path): base(name, path){}

    public override void StartProcess()
    {
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = _path;
        start.UseShellExecute = true;
        start.CreateNoWindow = false;
        Process.Start(start);
    }
}