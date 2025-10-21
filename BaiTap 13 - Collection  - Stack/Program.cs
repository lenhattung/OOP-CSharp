/*
Stack là cấu trúc dữ liệu hoạt động theo nguyên tắc 
LIFO (Last In First Out - Vào sau, Ra trước).
 */

using System.Collections.Generic;

Stack<int> numbers = new Stack<int>();

numbers.Push(100);
numbers.Push(5);
numbers.Push(10);
numbers.Push(20);

Console.WriteLine(numbers.Pop());  // 20
Console.WriteLine(numbers.Peek()); // 10
Console.WriteLine(numbers.Pop()); // 10

// ==============

Stack<string> browserHistory = new Stack<string>();

// Người dùng duyệt các trang
browserHistory.Push("google.com");
browserHistory.Push("facebook.com");
browserHistory.Push("youtube.com");

Console.WriteLine("Trang hiện tại: " + browserHistory.Peek());
// Output: youtube.com

// Nhấn nút "Quay lại"
string previousPage = browserHistory.Pop();
Console.WriteLine("Quay lại: " + browserHistory.Peek());
// Output: facebook.com

Console.WriteLine("Số trang trong lịch sử: " + browserHistory.Count);
// Output: 2

// ====================

string text = "Hello";
Stack<char> stack = new Stack<char>();

// Đưa từng ký tự vào Stack
foreach (char c in text)
{
    stack.Push(c);
}

// Lấy ra theo thứ tự ngược
string reversed = "";
while (stack.Count > 0)
{
    reversed += stack.Pop();
}

Console.WriteLine(reversed); // Output: olleH


// ========
bool IsValidParentheses(string s)
{
    Stack<char> stack = new Stack<char>();

    foreach (char c in s)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            if (stack.Count == 0) return false;

            char top = stack.Pop();
            if (c == ')' && top != '(') return false;
            if (c == '}' && top != '{') return false;
            if (c == ']' && top != '[') return false;
        }
    }

    return stack.Count == 0;
}

// Test
Console.WriteLine(IsValidParentheses("(){}[]"));     // True
Console.WriteLine(IsValidParentheses("({[]})"));     // True
Console.WriteLine(IsValidParentheses("({[})"));      // False