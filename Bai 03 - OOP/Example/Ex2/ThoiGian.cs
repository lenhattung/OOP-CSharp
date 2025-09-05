using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThoiGian
{
    // Fields (trường dữ liệu)
    private int nam;
    private int thang;
    private int ngay;
    private int gio;
    private int phut;
    private int giay;

    // Properties (Thuộc tính)
    public int Nam
    {
        get { return nam; } // getter
        set { nam = value >= 0 ? value : 0; } // setter
    }
    public int Thang
    {
        get { return thang; }
        set { thang = (value>=1 && value <= 12) ? value : 0; }
    }
    public int Ngay
    {
        get { return ngay; }
        set { ngay = (value >= 1 && value <= 31) ? value : 0; }
    }
    public int Gio
    {
        get { return gio; }
        set { gio = (value >= 0 && value <= 23) ? value : 0; }
    }
    public int Phut
    {
        get { return phut; }
        set { phut = (value >= 0 && value <= 59) ? value : 0; }
    }
    public int Giay
    {
        get { return giay; }
        set { giay = (value >= 0 && value <= 59) ? value : 0; }
    }

    // Constructor (hàm dựng, hàm khởi tạo)
    public ThoiGian() // Default Constructor
    {
        this.Nam = 0; // this => trỏ tới đối tượng hiện tại
        this.Thang = 0;
        this.Ngay = 0;
        this.Gio = 0;
        this.Phut = 0;
        this.Giay = 0;
    }

    public ThoiGian(int Nam, int Thang, int Ngay, int Gio, int Phut, int Giay) // constructor
    {
        this.Nam = Nam;
        this.Thang = Thang;
        this.Ngay = Ngay;
        this.Gio = Gio;
        this.Phut = Phut;
        this.Giay = Giay;
    }

    public ThoiGian(ThoiGian other) // Constructor sao chép
    {
        this.Nam = other.Nam;
        this.Thang = other.Thang;
        this.Ngay = other.Ngay;
        this.Gio = other.Gio;
        this.Phut = other.Phut;
        this.Giay = other.Giay;
    }

    public ThoiGian(DateTime dt) // Constructor sao chép
    {
        this.Nam = dt.Year;
        this.Thang = dt.Month;
        this.Ngay = dt.Day;
        this.Gio = dt.Hour;
        this.Phut = dt.Minute;
        this.Giay = dt.Second;
    }

    // Hàm mô tả đối tượng
    public override string ToString()
    {
        return $"{this.Nam}-{this.Thang}-{this.Ngay} {this.Gio}:{this.Phut}:{this.Giay}";
    }
}