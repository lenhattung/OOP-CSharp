using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SinhVien
{
    // Fields
    private string maSV;
    private string hoTen;
    private int namSinh;
    private double diemToan, diemLy, diemHoa;

    // Constructor
    public SinhVien()
    {
        MSV = "0000000000";
        HoTen = "No Name";
        NamSinh = 1900;
        DiemToan = 0;
        DiemLy = 0;
        DiemHoa = 0;
    }

    public SinhVien(string maSV, string hoTen, int namSinh, double diemToan, double diemLy, double diemHoa)
    {
        MSV = maSV;
        HoTen = hoTen;
        NamSinh = namSinh;
        DiemToan = diemToan;
        DiemLy = diemLy;
        DiemHoa = diemHoa;
    }


    // Properties + Getter/Setter
    public string MSV
    {
        get { return maSV; }
        set
        {
            if (value.Length == 10)
            {
                maSV = value;
            }
        }
    }

    public string HoTen
    {
        get { return hoTen; }
        set
        {
            if (value.Length >= 3 && value.Length <= 250)
            {
                hoTen = value;
            }
        }
    }

    public int NamSinh
    {
        get { return namSinh; }
        set {
            if (value >= 1900 && value <= 2025)
            {
                namSinh = value;
            }
        }
    }

    public double DiemToan
    {
        get { return diemToan; }
        set
        {
            if (value >= 0 && value <= 10)
            {
                diemToan = value;
            }
        }
    }
    public double DiemLy
    {
        get { return diemLy; }
        set
        {
            if (value >= 0 && value <= 10)
            {
                diemLy = value;
            }
        }
    }
    public double DiemHoa
    {
        get { return diemHoa; }
        set
        {
            if (value >= 0 && value <= 10)
            {
                diemHoa = value;
            }
        }
    }

    public double TinhDiemTB()
    {
        return (DiemToan + DiemLy + DiemHoa) / 3;
    }
    public void HienThiThongTin()
    {
        Console.WriteLine(ToString());
    }
    public string XepLoai()
    {
        double DiemTB = TinhDiemTB();
        if (DiemTB >= 8) return "Giỏi";
        else if (DiemTB >= 7) return "Khá";
        else if (DiemTB >= 5) return "Trung Bình";
        else return "Yếu";
    }

    // toString() là phương thức được kế thừa từ class Object,
    // được sử dụng để trả về chuỗi mô tả đối tượng.

    // Override: phương thức toString()
    public override string ToString()
    {
        return 
            $"Ma SV: {MSV}\n" +
            $"Ho Ten: {HoTen}\n" +
            $"Nam Sinh: {NamSinh}\n" +
            $"Diem Toan: {DiemToan}\n" +
            $"Diem Ly: {DiemLy}\n" +
            $"Diem Hoa: {DiemHoa}\n" +
            $"Xếp loại: {XepLoai()}";
    }

}
