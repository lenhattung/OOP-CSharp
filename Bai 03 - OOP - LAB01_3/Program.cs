using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_03___OOP___LAB01_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tạo một số sinh viên mẫu
            Student sv1 = new Student("SV001", "Nguyen Van A", new DateTime(2000, 5, 15), 3.2);
            Student sv2 = new Student("SV002", "Tran Thi B", new DateTime(1999, 8, 22), 3.8);
            Student sv3 = new Student("SV003", "Le Van C", new DateTime(2001, 1, 10), 2.9);
            Student sv4 = new Student("SV004", "Pham Thi D", new DateTime(2000, 12, 3), 1.8);

            // Tạo một số lớp học mẫu
            ClassRoom lop1 = new ClassRoom("CNTT01", "ThS. Nguyen Van X", 30);
            ClassRoom lop2 = new ClassRoom("KTPM02", "TS. Tran Thi Y", 25);

            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ SINH VIÊN ===\n");

            // Hiển thị thông tin sinh viên
            Console.WriteLine("=== THÔNG TIN SINH VIÊN ===");
            sv1.DisplayInfo();
            sv2.DisplayInfo();
            sv3.DisplayInfo();
            sv4.DisplayInfo();

            // Hiển thị thông tin lớp học
            Console.WriteLine("=== THÔNG TIN LỚP HỌC ===");
            lop1.DisplayClassInfo();
            lop2.DisplayClassInfo();

            // Thêm sinh viên vào lớp
            Console.WriteLine("=== THÊM SINH VIÊN VÀO LỚP ===");
            lop1.AddStudent(); // Giả sử thêm sv1
            lop1.AddStudent(); // Giả sử thêm sv2
            lop1.AddStudent(); // Giả sử thêm sv3

            lop2.AddStudent(); // Giả sử thêm sv4

            Console.WriteLine();
            lop1.DisplayClassInfo();
            lop2.DisplayClassInfo();

            // Test graduate
            Console.WriteLine("=== THỬ TỐT NGHIỆP ===");
            sv2.Graduate(); // Thành công (GPA = 3.8)
            sv4.Graduate(); // Thất bại (GPA = 1.8)

            Console.WriteLine();

            // Cập nhật GPA và thử lại
            Console.WriteLine("=== CẬP NHẬT GPA VÀ THỬ LẠI ===");
            sv4.GPA = 2.5;
            Console.WriteLine($"Đã cập nhật GPA của {sv4.FullName} thành {sv4.GPA}");
            sv4.Graduate(); // Thành công

            // Loại sinh viên khỏi lớp (do đã tốt nghiệp)
            Console.WriteLine("\n=== LOẠI SINH VIÊN ĐÃ TỐT NGHIỆP ===");
            lop1.RemoveStudent(); // sv2 tốt nghiệp
            lop2.RemoveStudent(); // sv4 tốt nghiệp

            Console.WriteLine();
            lop1.DisplayClassInfo();
            lop2.DisplayClassInfo();

            // Hiển thị thống kê cuối cùng
            Student.DisplayStudentStatistics();
            ClassRoom.DisplayClassStatistics();

            // Test thêm nhiều sinh viên để test lớp đầy
            Console.WriteLine("=== TEST LỚP ĐẦY ===");
            ClassRoom lopNho = new ClassRoom("TEST01", "GV Test", 2);
            lopNho.AddStudent();
            lopNho.AddStudent();
            lopNho.AddStudent(); // Sẽ thất bại vì đã đầy

            // Test static methods
            Console.WriteLine($"\nTổng số sinh viên trong hệ thống: {Student.GetTotalStudents()}");
            Console.WriteLine($"Sinh viên đang học: {Student.GetActiveStudents()}");
            Console.WriteLine($"Tổng số lớp: {ClassRoom.GetTotalClasses()}");

            // Test thay đổi tên trường
            Console.WriteLine($"\nTên trường hiện tại: {ClassRoom.GetSchoolName()}");
            ClassRoom.SetSchoolName("Trường Đại học Công nghệ XYZ");
            Console.WriteLine($"Tên trường mới: {ClassRoom.GetSchoolName()}");

            Console.WriteLine("\nNhấn Enter để thoát...");
            Console.ReadLine();
        }
    }
}
