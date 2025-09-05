using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestSinhVien
{
    public static void Main1()
    {
        SinhVien sv1 = new SinhVien("0123456789", "Le Nhat Tung", 2007, 10, 9, 8);
        sv1.HienThiThongTin();
    }
}