using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WebService : IStartable, ISaveable
{
    public bool IsRunning { get ; set ; }

    public void Load()
    {
        Console.WriteLine("Web service loaded status to file");
    }

    public void Save()
    {
        Console.WriteLine("Web service saved status to file");
    }

    public void Start()
    {
        Console.WriteLine("Web service listening on port 8080");
        IsRunning = true;
    }

    public void Stop()
    {
        Console.WriteLine("Web service stopped");
        IsRunning = false;
    }

}

