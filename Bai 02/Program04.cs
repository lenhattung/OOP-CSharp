/*
Tháng có 31 ngày: 1, 3, 5, 7, 8, 10, 12
Tháng có 30 ngày: 4, 6, 9, 11
Tháng 2: 28 ngày (năm thường) hoặc 29 ngày (năm nhuận)
 */

using System;

class DaysInMonth
{
    // Hàm kiểm tra năm nhuận
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static void Main()
    {
        int month, year;
        int days;

        Console.WriteLine("CHUONG TRINH TINH SO NGAY TRONG THANG");
        Console.WriteLine("====================================");

        // Nhập tháng
        Console.Write("Nhap thang (1-12): ");
        month = int.Parse(Console.ReadLine());


        // .... Bao loi va dung chuong trinh neu nhap thang sai

        // Nhập năm (để kiểm tra năm nhuận cho tháng 2)
        Console.Write("Nhap nam: ");
        year = int.Parse(Console.ReadLine());

        // Xác định số ngày trong tháng
        // switch ... case / kết hơp if ... elss


    }
}


