using System.IO;
using System.Text.Json;

abstract class ProcessInfo
{
    protected string _name;
    protected string _path;
    protected bool _status;

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

    abstract public void StartProcess();
}