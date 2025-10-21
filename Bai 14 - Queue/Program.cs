/*
Queue là cấu trúc dữ liệu hoạt động theo nguyên tắc FIFO (First In First Out - Vào trước, Ra trước).
Ví dụ thực tế:
- Xếp hàng mua vé: Người đến trước được phục vụ trước
- Hàng đợi in ấn: Tài liệu gửi trước được in trước
- Hệ thống xử lý yêu cầu: Request đến trước xử lý trước
- Call center: Cuộc gọi đến trước được trả lời trước
 */



using System.Collections.Generic;

public class Test
{

    public static void Main()
    {

        Queue<int> numbers = new Queue<int>();

        Queue<string> printQueue = new Queue<string>();

        // Gửi tài liệu vào hàng đợi
        printQueue.Enqueue("Báo cáo.pdf");
        printQueue.Enqueue("Hợp đồng.pdf");
        printQueue.Enqueue("Hóa dơn.pdf");

        // Tài liệu đang in ấn
        Console.WriteLine("Đang in: " + printQueue.Peek());

        // Hoàn thành một tài liệu in
        Console.WriteLine("Đã in xong: " + printQueue.Dequeue());

        // Tài liệu tiếp theo đang in là
        Console.WriteLine("Đang in: " + printQueue.Peek());

        Console.WriteLine("Số tài liệu đang chờ: " + printQueue.Count);
        // Output: 2
    }
}