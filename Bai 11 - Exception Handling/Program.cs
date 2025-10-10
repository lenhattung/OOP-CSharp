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
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        ViDu3();
    }
}