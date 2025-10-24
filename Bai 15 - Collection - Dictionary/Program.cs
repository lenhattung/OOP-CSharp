// <Key, Value>

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void DemoPhoneBook()
    {
        // Key: Tên người
        // Value: Số điện thoại

        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        // Thêm số điện thoại:
        phoneBook.Add("Nguyễn Văn A", "0123456789");
        phoneBook.Add("Trần Thị B", "0912345678");
        phoneBook.Add("Lê Văn C", "0923456789");
        phoneBook.Add("Phạm Thị D", "0934567890");

        Console.WriteLine("Hiện tại có: " + phoneBook.Count+" số điện thoại");

        // Cách 1
        phoneBook.TryGetValue("Nguyễn Văn A", out string sdt);
        Console.WriteLine("Nguyễn Văn A có sđt là: " + sdt);

        // Cách 2
        string key = "Trần Thị B";
        if (phoneBook.ContainsKey(key))
        {
            Console.WriteLine($"{key} : {phoneBook[key]}");
        }

        // Hiển thị toàn bộ danh bạ:
        Console.WriteLine("Toàn bộ danh bạ:");
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"   {contact.Key}: {contact.Value}");
        }

    }

    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = Encoding.UTF8;
    //    DemoPhoneBook();

    //}
}