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
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        ViDu1();
    }
}