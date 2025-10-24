using System;
using System.IO;
using System.Text;

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
        File.Delete(path);
        // Directory.Delete(path2); => chỉ xóa được nếu thư mục rỗng.
        Directory.Delete(path2, recursive: true); // xóa nội dung bên trong thư mục, xóa bản thân nó
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
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        //ViDu1();
        // ViDu2();
        ViDu3();
    }
}