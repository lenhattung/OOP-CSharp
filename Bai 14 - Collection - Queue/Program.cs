/*
 Queue - FIFO - First In First Out
 */

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void DemoBasicQueueOperations()
    {
        Queue<int> numbers = new Queue<int>();

        numbers.Enqueue(10);
        numbers.Enqueue(20);
        numbers.Enqueue(30);
        numbers.Enqueue(40);

        Console.WriteLine("Peek() - Phần tử đầu tiên: " + numbers.Peek());
        Console.WriteLine("Dequeue() - Lấy ra: " + numbers.Dequeue());
        Console.WriteLine("Peek() - Phần tử đầu tiên hiện tại: " + numbers.Peek());
        Console.WriteLine("Số phần tử còn lại: " + numbers.Count);
        Console.WriteLine();

    }

    static void DemoPrintQueue()
    {
        Console.WriteLine("=== VÍ DỤ 2: HÀNG ĐỢI IN ẤN ===");

        Queue<string> printQueue = new Queue<string>();

        // Gửi tài liệu vào hàng đợi
        printQueue.Enqueue("Báo cáo.pdf");
        printQueue.Enqueue("Hợp đồng.pdf");
        printQueue.Enqueue("Hóa đơn.pdf");

        Console.WriteLine("📄 Đã thêm 3 tài liệu vào hàng đợi in");
        Console.WriteLine();

        // Tài liệu đang in
        Console.WriteLine("🖨️  Đang in: " + printQueue.Peek());

        // Hoàn thành một tài liệu in
        Console.WriteLine("✅ Đã in xong: " + printQueue.Dequeue());
        Console.WriteLine();

        // Tài liệu tiếp theo
        Console.WriteLine("🖨️  Đang in: " + printQueue.Peek());
        Console.WriteLine("📋 Số tài liệu đang chờ: " + printQueue.Count);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        DemoBasicQueueOperations();
        DemoPrintQueue();
    }
}
