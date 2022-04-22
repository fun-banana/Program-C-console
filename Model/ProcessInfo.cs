using System.IO;
using System.Text.Json;
using System.Diagnostics;

class ProcessInfo
{
    private string _name;
    private string _path;
    private bool _status;

    public string Name => _name;
    public string Path => _path;
    public bool Status => _status;

    public ProcessInfo(string name, string path)
    {
        SetName(name);
        SetPath(path);
        SetStatus(false);
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetPath(string path)
    {
        if (File.Exists(path))
        {
            _path = path;
        }
        else 
        {
            throw new FileNotFoundException("Wrong path to file.");
        }
    }

    public void SetStatus(bool status)
    {
        _status = status;
    }

    public void SaveAsJson(string folderPath = ".")
    {
        string jsonString = JsonSerializer.Serialize(this);
        File.WriteAllText(folderPath + '/' + _name + ".json", jsonString);
    }

    public void StartProcess()
    {
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = _path;
        start.UseShellExecute = true;
        start.CreateNoWindow = false;
        Process.Start(start);
    }
}