using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

public class Program
{
    public static void ViDu1()
    {
        // Kiểm tra file
        string path = @"D:\ViDu.txt";

        if (File.Exists(path))
        {
            Console.WriteLine("File đã tồn tại!");
        }
        else
        {
            File.Create(path).Close();
        }

        // Kiểm tra Directory
        string path2 = @"D:\DEx1";

        if (Directory.Exists(path))
        {
            Console.WriteLine("Directory đã tồn tại!");
        }
        else
        {
            Directory.CreateDirectory(path2);
        }

        // Lấy thông tin
        FileInfo fileInfo = new FileInfo(path);
        DirectoryInfo dInfo2 = new DirectoryInfo(path2);
        Console.WriteLine($"Tên file: {fileInfo.Name}");
        Console.WriteLine($"Kích thước: {fileInfo.Length} bytes");
        Console.WriteLine($"Ngày tạo: {fileInfo.CreationTime}");
        Console.WriteLine("====");
        Console.WriteLine($"Tên file: {dInfo2.Name}");
        Console.WriteLine($"Ngày tạo: {dInfo2.CreationTime}");

        // Xóa
        //File.Delete(path);
        // Directory.Delete(path2); => chỉ xóa được nếu thư mục rỗng.
        // Directory.Delete(path2, recursive: true); // xóa nội dung bên trong thư mục, xóa bản thân nó
        // Directory.Delete(@"D:\", recursive: true); // xóa sạch ổ D
    }

    public static void ViDu2()
    {
        Console.WriteLine("==== NHẬP THÔNG TIN CÁ NHÂN ==== ");

        // Nhập từ console
        Console.Write("Họ tên: ");
        string hoTen = Console.ReadLine();

        Console.Write("Tuổi: ");
        string tuoi = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        // Ghi vào file
        string content = $"Họ tên: {hoTen}\nTuổi: {tuoi}\nEmail: {email}";
        File.WriteAllText( @"D:\thongtin.txt", content , Encoding.UTF8); // Luôn ghi đè.
        //File.AppendAllText(email , content , Encoding.UTF8);// Nối dữ liệu vào cuối

        // Đọc lại và hiển thị
        Console.WriteLine("=== Nội dung file === ");
        string doc = File.ReadAllText(@"D:\thongtin.txt",  Encoding.UTF8);
        Console.WriteLine(doc);
    }

    public static void ViDu3()
    {
        Console.WriteLine("=== NHẬP DANH SÁCH SẢN PHẨM ===");
        Console.WriteLine("(Gõ 'STOP' để dừng)\n");

        string filePath = @"D:\sanpham.txt";

        // Ghi từng dòng
        using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
        {
            int stt = 1;
            while (true)
            {
                Console.Write($"Sản phẩm {stt}: ");
                string sp = Console.ReadLine();

                if (sp.ToUpper() == "STOP")
                    break;

                writer.WriteLine($"{stt} : {sp}");
                stt ++;
            }
        }

        // ĐỌC với StreamReader (nhất quán với StreamWriter)
        Console.WriteLine("\n--- Danh sách đã lưu ---");

        using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
        {
            string line;
            int count = 0;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                count++;
            }

            Console.WriteLine($"Tổng: {count} sản phẩm");
        }
    }

    public static void ViDu4()
    {
        // tạo đối tượng
        SinhVien sv = new SinhVien
        {
            MaSV = 123,
            HoTen = "Nguyễn Văn A",
            NgaySinh = new DateTime(2003, 5, 15),
            DiemTB = 8.7,
            Lop = "CNTT01"
        };

        string path = @"D:\sv.dat";

        // ===== ghi đối tượng ra file nhị phân =====
        string json = sv.ToJson();
        Console.WriteLine(json);
        File.WriteAllText(path, json);

        string json2 = File.ReadAllText(path);
        SinhVien sv2 = SinhVien.FromJson(json2);
        Console.WriteLine(sv2.ToString());
    }

    public static void ViDu5()
    {
        // tạo đối tượng
        List<SinhVien> ds = new List<SinhVien>
        {
            new SinhVien { MaSV = 101, HoTen = "Nguyễn Văn A", NgaySinh = new DateTime(2003, 5, 15), DiemTB = 8.7, Lop = "CNTT01" },
            new SinhVien { MaSV = 102, HoTen = "Trần Thị B", NgaySinh = new DateTime(2002, 9, 10), DiemTB = 7.9, Lop = "CNTT01" },
            new SinhVien { MaSV = 103, HoTen = "Lê Văn C", NgaySinh = new DateTime(2004, 1, 22), DiemTB = 9.1, Lop = "CNTT02" }
        };

        string path = @"D:\ds_sinhvien.json";

        // ===== ghi danh sách ra file JSON =====
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(ds, options);
        File.WriteAllText(path, json);
        Console.WriteLine("Đã lưu danh sách sinh viên xuống file JSON!");

        // ===== đọc lại danh sách từ file =====
        string json2 = File.ReadAllText(path);
        List<SinhVien> ds2 = JsonSerializer.Deserialize<List<SinhVien>>(json2);

        Console.WriteLine("\nDanh sách sinh viên đọc lại từ file:");
        foreach (var sv in ds2)
        {
            Console.WriteLine(sv.ToString());
        }
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        //ViDu1();
        // ViDu2();
        //ViDu3();
        //ViDu4();
        ViDu5();
    }
}