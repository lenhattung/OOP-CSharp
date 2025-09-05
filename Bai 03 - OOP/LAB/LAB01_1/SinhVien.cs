using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB01_1
{
    public class SinhVien
    {
        // Fields
        private string msv;
        private string ten;
        private string khoa;
        private double diemTB;

        // Thuộc tính
        public string Msv
        {
            get { return msv; } 
            set {
                // regex - https://vietnix.vn/regex-la-gi/
                string regex = "^\\d{10}$";
                msv = Regex.IsMatch(value, regex)?value:"0000000000"; 
            }
        }

        public string Ten
        {
            get { return toTitleCase(ten); }
            set {
                string regex = "^.{5,100}$";
                ten = Regex.IsMatch(value, regex) ? value : "No Name";
            }
        }

        public string Khoa
        {
            get { return toTitleCase(khoa); }
            set { khoa = value; }
        }
        public double DiemTB { 
            get { return diemTB; } 
            set { diemTB = (value>=0 && value<=10)?value:0; } 
        }

        // constructor
        public SinhVien()
        {
            this.Msv = string.Empty;
            this.Ten = string.Empty;
            this.Khoa = string.Empty;
            this.DiemTB = 0;
        }

        public SinhVien(string Msv, string Ten, string Khoa, double DiemTB)
        {
            this.Msv= Msv;
            this.Ten= Ten;
            this.Khoa= Khoa;
            this.DiemTB= DiemTB;
        }
        public override string ToString()
        {
            return $"{this.Msv}, {this.Ten}, {this.Khoa}, {this.DiemTB}";
        }

        public string toTitleCase(string text)
        {
            string result = "";
            // le nhat tung => Le Nhat Tung
            string[] words = text.Split(" "); // cắt chuỗi thành mảng từng từ
            foreach (string word in words)
            {
                // le => Le // LE => Le 
                string kyTuDau = "";
                string cacKyTuConLai = "";
                if (word.Length >=1)                
                    kyTuDau = word.Substring(0, 1).ToUpper(); // Lấy ký tự đầu tiên => chuyển thành chữ hoa
                if (word.Length >= 2)
                    cacKyTuConLai = word.Substring(1).ToLower(); // Lấy ký tự còn lại > > chuyển thành chữ thường
                string newWorld = kyTuDau + cacKyTuConLai;
                result = result + " " + newWorld;
            }
            return result.Trim() ; // xóa đi khoảng trắng dư thừa ở 2 đầu
        }

        public void input()
        {
            Console.Write("MSV: ");
            this.Msv = Console.ReadLine();
            Console.Write("Tên: ");
            this.Ten = Console.ReadLine();
            Console.Write("Khoa: ");
            this.Khoa = Console.ReadLine();
            Console.Write("Điểm TB: ");
            this.DiemTB = double.Parse(Console.ReadLine());
        }

        public void show()
        {
            Console.WriteLine(this);
        }
    }
}
