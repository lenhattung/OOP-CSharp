using System;
using System.Text;

public class Program
{

    public static void ViDu1()
    {
        try
        {
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());

            int result = a / b;
            Console.WriteLine($"Kết quả: {result}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Có lỗi xảy ra trong quá trình tính toán!");
        }

        Console.WriteLine("Chương trình kết thúc.");
    }

    public static void ViDu2()
    {
        try
        {
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());

            int result = a / b;
            Console.WriteLine($"Kết quả: {result}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Lỗi: không được chia cho 0!");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Lỗi: vui lòng nhập số hợp lệ!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Lỗi: không xác định!");
        }
       

        Console.WriteLine("Chương trình kết thúc.");
    }

    public static void ViDu3()
    {
        try
        {
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());

            int result = a / b;
            Console.WriteLine($"Kết quả: {result}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Lỗi: không được chia cho 0!");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Lỗi: vui lòng nhập số hợp lệ!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Lỗi: không xác định!");
        }
        finally
        {
            Console.WriteLine("Cảm ơn quý khách đã sử dụng chương trình.");
        }

        Console.WriteLine("Chương trình kết thúc.");
    }

    public static void ViDu4()
    {
        try
        {
            Console.Write("Nhập tuổi: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                throw new Exception("Tuổi không được âm!");
            }

            if (age > 150)
            {
                throw new Exception("Tuổi không hợp lệ!");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Lỗi: Vui lòng nhập số!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Lỗi: "+e.Message); ;
        }
    }

    // Custom Exception
    public static void ViDu5()
    {
        try
        {
            Console.Write("Nhập tuổi: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                throw new InvalidAgeException("Tuổi không được âm!");
            }

            if (age > 150)
            {
                throw new InvalidAgeException("Tuổi không hợp lệ!");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Lỗi: Vui lòng nhập số!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Lỗi: " + e.Message); ;
        }
    }

    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        ViDu5();
    }
}


/*
 * 
 * Bài 1 - ViDu6: Viết chương trình tính giai thừa với xử lý exception
 * 
 * Bài 2 - ViDu7: Tính căn bậc hai. Viết chương trình nhập 1 số và tính căn bậc hai. Xử lý lỗi khi nhập số âm.
 * 
 * Bài 3 - ViDu8: Kiểm tra email Tạo exception InvalidEmailException. Email phải chứa '@'.
 * 
 * Bài 4 - Tạo dự án mới:

using System;
using System.Text;

// Tạo custom exception cho số dư không đủ
class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

// Tạo custom exception cho số tiền không hợp lệ
class InvalidAmountException : Exception
{
    public InvalidAmountException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        try
        {
            double balance = 1000000; // 1 triệu đồng
            
            Console.WriteLine($"Số dư hiện tại: {balance:N0} VNĐ");
            Console.Write("Nhập số tiền muốn rút: ");
            double withdraw = double.Parse(Console.ReadLine());
            
            // Kiểm tra số tiền âm
            if (withdraw <= 0)
                throw new InvalidAmountException("Số tiền rút phải lớn hơn 0!");
            
            // Kiểm tra số dư
            if (withdraw > balance)
                throw new InsufficientBalanceException("Số dư không đủ!");
            
            balance -= withdraw;
            Console.WriteLine($"\nRút tiền thành công!");
            Console.WriteLine($"Số tiền đã rút: {withdraw:N0} VNĐ");
            Console.WriteLine($"Số dư còn lại: {balance:N0} VNĐ");
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"\n LỖI SỐ DƯ: {ex.Message}");
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine($"\n LỖI SỐ TIỀN: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\n LỖI NHẬP LIỆU: Vui lòng nhập số!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\n LỖI: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nCảm ơn bạn đã sử dụng dịch vụ!");
        }
    }
}
 

 * 
 */

