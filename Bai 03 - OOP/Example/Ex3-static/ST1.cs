using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_03.Example.Ex3_static
{
    public class ST1
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

        // static fields - thuộc về class
        public static int TotalStudents = 0;

        // Instance field
        private string name;
        public string Name
        {
            get { return StringUtils.toTitleCase(name);  }
            set { name = value; }
        }

        public ST1(string name)
        {
            Name = name;
            TotalStudents++;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Ban dau co: {ST1.TotalStudents} st");
            ST1 st1 = new ST1("nguyen VAN A");
            Console.WriteLine(st1.Name);

            ST1 st2 = new ST1("Nguyen Van B");
            ST1 st3 = new ST1("Nguyen Van C");
            Console.WriteLine($"Sau do co: {ST1.TotalStudents} st");

        }
    }
}