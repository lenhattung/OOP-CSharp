using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HocSinh
{
    public string Name { get; set; }

    private double[] diem = new double[5];

    // Indexer: cho phép truy cập như mảng
    public double this[int index]
    {
        get
        {
            if (index >= 0 && index < diem.Length)
            {
                return diem[index];
            }
            return -1;
        }
        set
        {
            if (index >= 0 && index < diem.Length)
            {
                diem[index] = value;
            }
        }
    }

}

