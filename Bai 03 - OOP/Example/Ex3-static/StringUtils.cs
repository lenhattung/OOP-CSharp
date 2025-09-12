using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_03.Example.Ex3_static
{
    public class StringUtils
    {
        public static string toTitleCase(string text)
        {
            string result = "";
            // le nhat tung => Le Nhat Tung
            string[] words = text.Split(" "); // cắt chuỗi thành mảng từng từ
            foreach (string word in words)
            {
                // le => Le // LE => Le 
                string kyTuDau = "";
                string cacKyTuConLai = "";
                if (word.Length >= 1)
                    kyTuDau = word.Substring(0, 1).ToUpper(); // Lấy ký tự đầu tiên => chuyển thành chữ hoa
                if (word.Length >= 2)
                    cacKyTuConLai = word.Substring(1).ToLower(); // Lấy ký tự còn lại > > chuyển thành chữ thường
                string newWorld = kyTuDau + cacKyTuConLai;
                result = result + " " + newWorld;
            }
            return result.Trim(); // xóa đi khoảng trắng dư thừa ở 2 đầu
        }

        public static string[] toWordArray(string text)
        {
            return text.Split(" ");
        }
        
        public static string numberToString(int number)
        {
            // 100 => mot tram
            // 101 => mot tram le 1
            return "";
        }
    }
}
