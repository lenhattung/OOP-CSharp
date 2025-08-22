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

    public static void Main()
    {
        int month, year;
        int days;

        Console.WriteLine("CHUONG TRINH TINH SO NGAY TRONG THANG");
        Console.WriteLine("====================================");


        do {
            Console.Write("Nhap thang (1-12): ");
            month = int.Parse(Console.ReadLine());
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Thang khong hop le! Vui long nhap tu 1 den 12.");
            }
        } while (month <1 || month>12);

        // Kiểm tra tháng hợp lệ
        // Nếu không hợp lệ thì báo lỗi và kết thúc chương trình
        //if(month<1 || month > 12)
        //{
        //    Console.WriteLine("Thang khong hop le! Vui long nhap tu 1 den 12.");
        //    return;
        //}

        // Nhập năm (để kiểm tra năm nhuận cho tháng 2)
        Console.Write("Nhap nam: ");
        year = int.Parse(Console.ReadLine());

        // Xác định số ngày trong tháng
        // switch ... case
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                days = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                days = 30;
                break;
            case 2:
                if (IsLeapYear(year))
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
                break;
            default:
                days = 0; break;

        }

        // In kết quả
        Console.WriteLine("\nKet qua:");
        Console.WriteLine("Thang {0} nam {1} co {2} ngay", month, year, days);
    }
}

