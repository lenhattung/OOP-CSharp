using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    // Auto-properties đơn giản
    public string Name {  get; set; }
    public int Age { get; set; }

    // Auto-properties với giá trị mặc định
    public DateTime EnrollDate { get; set; } = DateTime.Now;

    public double GPA { get; set; } = 0.0;

}

