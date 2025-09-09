using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_03.Example.Ex3_static
{
    public class Student1
    {
        /*
         Từ khóa static trong C# được sử dụng để tạo ra các thành phần (members) thuộc về class 
         chứ không thuộc về instance cụ thể nào của class đó. Điều này có nghĩa là:
            Không cần tạo đối tượng để truy cập
            Được chia sẻ chung giữa tất cả các instance
            Tồn tại trong suốt vòng đời của chương trình

        Tại sao cần Static?
            Tiết kiệm bộ nhớ: Chỉ có một bản copy duy nhất
            Tiện lợi: Không cần tạo instance để sử dụng
            Utility functions: Phù hợp cho các hàm tiện ích chung
            Constants và shared data: Lưu trữ dữ liệu chung
         */

        // static fields - thuộc về class, không thuộc về instance
        public static int TotalStudents = 0;

        // Instance field - thuộc về từng instance riêng biệt
        public string Name;

        public Student1(string name)
        {
            Name = Utils.toTitleCase(name);
            TotalStudents++;
        }

    }

    class Program
    {
        public static void Main()
        {
            Console.WriteLine($"Ban đầu: {Student1.TotalStudents} sinh viên");

            Student1 sv1 = new Student1("nguyen thi hoa");
            // sv1.TotalStudents => Khôn thuộc về đối sv1
            Student1 sv2 = new Student1("duong moc lan");

            Console.WriteLine($"Sau khi tạo sinh viên: {Student1.TotalStudents} sinh viên");
        }
    }
}
