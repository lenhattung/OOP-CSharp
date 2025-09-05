using System;
using System.Collections.Generic;
using System.Linq;
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

        // Properties
        public string Msv
        {
            get { return msv; }
            set
            {
                string regex = "^\\d{10}$";
                msv = Regex.IsMatch(value, regex) ? value : "0000000000";
            }
        }

        public string Ten
        {
            get { return toTitleCase(ten); }
            set
            {
                string regex = "^.{5,100}$";
                ten = Regex.IsMatch(value, regex) ? value : "No Name";
            }
        }

        public string Khoa
        {
            get { return toTitleCase(khoa); }
            set
            {
                khoa = value;
            }
        }
        public double DiemTB
        {
            get { return diemTB; }
            set
            {
                diemTB = (value >= 0 && value <= 10) ? value : 0;
            }
        }


        // Constructor
        public SinhVien()
        {
            this.Msv = "";
            this.Ten = "";
            this.Khoa = "";
            this.DiemTB = 0;
        }
        public SinhVien(string Msv, string Ten, String Khoa, double DiemTB)
        {
            this.Msv = Msv;
            this.Ten = Ten;
            this.Khoa = Khoa;
            this.DiemTB = DiemTB;
        }

        public override string ToString()
        {
            return this.Msv + ", " + this.Ten + ", " + this.Khoa + ", " + this.DiemTB;
        }

        public string toTitleCase(string text)
        {
            string ketQua = "";
            // le nhat tung => Le Nhat Tung
            string[] words = text.Split(" "); // cắt từng tự
            foreach (string word in words)
            {
                string kyTuDauTien = (word.Substring(0, 1)).ToUpper(); // Lấy ký tự đầu tiên => viết hoa
                string kyTuConLai = (word.Substring (1)).ToLower(); // Lấy ký tự còn lại => viết thường
                string tu = kyTuDauTien + kyTuConLai;
                ketQua += tu + " ";
            }
            return ketQua.Trim();
        }

        public void input()
        {
            Console.WriteLine("Nhập vào mã số sinh viên: ");
            this.Msv = Console.ReadLine();
            Console.WriteLine("Nhập vào tên: ");
            this.Ten = Console.ReadLine();
            Console.WriteLine("Nhập vào Khoa: ");
            this.Khoa = Console.ReadLine();
            Console.WriteLine("Nhập vào điểm trung bình: ");
            this.DiemTB = Double.Parse(Console.ReadLine());
        }

        public void show()
        {
            Console.WriteLine(this.ToString());
        }
    }
}