/*
Lập trình hướng đối tượng (Object-Oriented Programming - OOP) 
là một phương pháp lập trình dựa trên khái niệm "đối tượng",
trong đó mỗi đối tượng chứa dữ liệu (thuộc tính) 
và mã (phương thức) để xử lý dữ liệu đó.

Ưu điểm của OOP
Tái sử dụng code: Có thể sử dụng lại các class đã viết
Bảo mật dữ liệu: Che giấu thông tin không cần thiết (Encapsulation)
Dễ bảo trì: Code được tổ chức theo cấu trúc rõ ràng
Mở rộng dễ dàng: Có thể thêm tính năng mới mà không ảnh hưởng code cũ

Class là một bản mẫu (template) để tạo ra các đối tượng. 
Nó định nghĩa các thuộc tính và phương thức mà đối tượng sẽ có.

 */

using System.Reflection.Metadata.Ecma335;

public class HocSinh
{
    // Fields (Trường dữ liệu) là các biến được khai báo trực tiếp trong class để lưu trữ dữ liệu
    private string hoTen;
    private int tuoi;
    private double diemTB;
    // Encapsulation (đóng gói) là nguyên lý che giấu dữ liệu bên trong class
    // và chỉ cho phép truy cập thông qua các phương thức được định nghĩa.

    // Properties (Thuộc tính)
    // Properties cung cấp cách thức linh hoạt để đọc,
    // ghi hoặc tính toán giá trị của các field riêng tư.
    // Sử dụng GETTER/ SETTER
    public string HoTen {
        get;
        set;
    }
    public int Tuoi
    {
       get {  return tuoi; }
       set
        {
            if(value>0 && value <= 100)
            {
                tuoi = value;
            }
        }
    }
    public double DiemTB
    {
        get { return diemTB; }
        set
        {
            if (value >=0 && value <= 10)
            {
                diemTB = value;
            }

        }
    }

    /*
     Constructor là phương thức đặc biệt được gọi tự động khi tạo một đối tượng mới. 
     Nó được sử dụng để khởi tạo giá trị ban đầu cho đối tượng.
     Đặc điểm của Constructor
        Có tên giống tên class
        Không có kiểu trả về
        Có thể có nhiều constructor (overloading)
        Nếu không định nghĩa, C# sẽ tạo default constructor
     */

    // Default Constructor
    public HocSinh()
    {
        HoTen = "No Name";
        Tuoi = 0;
        DiemTB = 0;
    }

    // Có thể tạo nhiều Constructor, chúng ta gọi là overloading

    //  Parameterized Constructor
    public HocSinh(string hoTen,  int tuoi, double diemTB)
    {
        HoTen = hoTen;
        Tuoi =  tuoi;
        DiemTB = diemTB;
    }

    public HocSinh(string hoTen, int tuoi)
    {
        HoTen = hoTen;
        Tuoi = tuoi;
        DiemTB = 0;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine(ToString());
    }
    public string XepLoai()
    {
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
        return $"Họ tên: {HoTen}\n" +
            $"Tuoi: {Tuoi}\n" +
            $"DiemTB: {DiemTB}\n" +
            $"Xếp loại: {XepLoai()}";
    }
}