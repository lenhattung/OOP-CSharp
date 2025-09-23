using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IStartable
{
    void Start();
    void Stop();
    bool IsRunning { get; set; }

}
