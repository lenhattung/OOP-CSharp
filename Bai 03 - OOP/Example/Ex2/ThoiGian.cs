using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThoiGian
{
    // Fields (các trường dữ liệu)
    private int nam = 0; // có thể gán giá trị mặc định
    private int thang;
    private int ngay;
    private int gio;
    private int phut;
    private int giay;

    // Properties (các thuộc tính)
    public int Nam
    {
        get { return nam; }
        set { nam = value >= 0 ? value : 0; } // encapsulation
    }
    public int Thang
    {
        get { return thang; }
        set { thang = value >= 0 ? value : 0; } // encapsulation
    }
    public int Ngay
    {
        get { return ngay; }
        set { ngay = value >= 0 ? value : 0; } // encapsulation
    }
    public int Gio
    {
        get { return gio; }
        set { gio = value >= 0 ? value : 0; } // encapsulation
    }
    public int Phut
    {
        get { return phut; }
        set { phut = value >= 0 ? value : 0; } // encapsulation
    }
    public int Giay
    {
        get { return giay; }
        set { giay = value >= 0 ? value : 0; } // encapsulation
    }

    // Constructor (hàm dựng / hàm khởi tạo)
    public ThoiGian()
    {
        this.Nam = 0; // this trỏ tới đối tượng hiện tại.
        this.Thang = 0;
        this.Ngay = 0;
        this.Gio = 0;
        this.Phut = 0;
        this.Giay = 0;
    }

    public ThoiGian(int Nam, int Thang, int Ngay, int Gio, int Phut, int Giay) // Hàm dựng có tham số
    {
        this.Nam = Nam;
        this.Thang = Thang;
        this.Ngay = Ngay;
        this.Gio = Gio;
        this.Phut = Phut;
        this.Giay = Giay;
    }

    public ThoiGian(ThoiGian that) // Hàm dựng sao chép
    {
        this.Nam = that.Nam;
        this.Thang = that.Thang;
        this.Ngay = that.Ngay;
        this.Gio = that.Gio;
        this.Phut = that.Phut;
        this.Giay = that.Giay;
    }

    public ThoiGian(DateTime dt) // Hàm dựng sao chép
    {
        this.Nam = dt.Year;
        this.Thang = dt.Month;
        this.Ngay = dt.Day;
        this.Gio = dt.Hour;
        this.Phut = dt.Minute;
        this.Giay = dt.Second;
    }

    public override string ToString()
    {
        return Nam + "-" + Thang + "-" + Ngay + " " + Gio + ":" + Phut + ":" + Giay;
    }
}
