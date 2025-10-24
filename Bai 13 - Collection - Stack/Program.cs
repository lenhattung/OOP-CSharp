/*
- Stack là cấu trúc dữ liệu hoạt động theo nguyên tắc 
- LIFO (Last In First Out - Vào sau, Ra trước).
 */

using System;
using System.Collections.Generic;

class Program
{
    public static void Demo1()
    {
        Console.WriteLine("=== DEMO 1 === ");

        Stack<int> numbers = new Stack<int>();
        numbers.Push(100);
        numbers.Push(5);
        numbers.Push(10);
        numbers.Push(20);

        Console.WriteLine("Pop(): " + numbers.Pop()); // 20
        Console.WriteLine("Peek(): " + numbers.Peek()); // 10
        Console.WriteLine("Pop(): " + numbers.Pop()); // 10

    }

    // Ví dụ 2: Mô phỏng lịch sử trình duyệt
    static void DemoBrowserHistory()
    {
        Console.WriteLine("=== VÍ DỤ 2: LỊCH SỬ TRÌNH DUYỆT ===");

        Stack<string> browserHistory = new Stack<string>();

        // Người dùng duyệt các trang
        browserHistory.Push("google.com");
        browserHistory.Push("facebook.com");
        browserHistory.Push("youtube.com");

        Console.WriteLine("Trang hiện tại: " + browserHistory.Peek());
        // Output: youtube.com

        // Nhấn nút "Quay lại"
        string previousPage = browserHistory.Pop();
        Console.WriteLine("Đã rời khỏi: " + previousPage);
        Console.WriteLine("Quay lại: " + browserHistory.Peek());
        // Output: facebook.com

        Console.WriteLine("Số trang trong lịch sử: " + browserHistory.Count);
        // Output: 2
        Console.WriteLine();
    }

    static string ReverseString(string text)
    {
        Stack<char> stack = new Stack<char>();
        string reversed = "";



        return reversed;
    }

    static void DemoReverseString()
    {
        Console.WriteLine("=== VÍ DỤ 3: ĐẢO NGƯỢC CHUỖI ===");

        string text = "Hello";
        string reversed = ReverseString(text);

        Console.WriteLine("Chuỗi gốc: " + text);
        Console.WriteLine("Chuỗi đảo ngược: " + reversed);
        Console.WriteLine();
    }
    static bool IsValidParentheses(string s)
    {
        Stack<char> stack = new Stack<char>();

        return true;
    }
    static void DemoValidParentheses()
    {
        Console.WriteLine("=== VÍ DỤ 4: KIỂM TRA DẤU NGOẶC HỢP LỆ ===");

        string[] testCases = { "(){}[]", "({[]})", "({[})", "((", "())" };

        foreach (string testCase in testCases)
        {
            bool isValid = IsValidParentheses(testCase);
            Console.WriteLine($"Chuỗi '{testCase}': {(isValid ? "HỢP LỆ ✓" : "KHÔNG HỢP LỆ ✗")}");
        }
        Console.WriteLine();
    }

    // Hàm Main - Chạy tất cả các ví dụ


    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Demo1();
        DemoBrowserHistory();
        DemoReverseString();
        DemoValidParentheses();
    }

   
}