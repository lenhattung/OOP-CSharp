Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

try
{
    Console.Write("Enter first number: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    int b = int.Parse(Console.ReadLine());

    int result = a / b;
    Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero!");
    Console.WriteLine($"Details: {ex.Message}");
}
catch (FormatException ex)
{
    Console.WriteLine("Error: Please enter valid numbers!");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
}


Console.WriteLine("Thuc thi cau lenh cuoi");


//===================================================


try
{
    Console.Write("Nhập số lượng môn học: ");
    int subjects = int.Parse(Console.ReadLine());

    if (subjects <= 0)
        throw new ArgumentException("Số môn học phải lớn hơn 0!");

    double totalScore = 0;

    for (int i = 1; i <= subjects; i++)
    {
        Console.Write($"Nhập điểm môn {i} (0-10): ");
        double score = double.Parse(Console.ReadLine());

        if (score < 0 || score > 10)
            throw new ArgumentOutOfRangeException("Điểm phải từ 0 đến 10!");

        totalScore += score;
    }

    double average = totalScore / subjects;
    Console.WriteLine($"Điểm trung bình: {average:F2}");

    if (average >= 8)
        Console.WriteLine("Xếp loại: Giỏi");
    else if (average >= 6.5)
        Console.WriteLine("Xếp loại: Khá");
    else if (average >= 5)
        Console.WriteLine("Xếp loại: Trung bình");
    else
        Console.WriteLine("Xếp loại: Yếu");
}
catch (FormatException ex)
{
    Console.WriteLine("Lỗi: Vui lòng nhập số hợp lệ!");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Lỗi: {ex.Message}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Lỗi: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Lỗi không mong đợi: {ex.Message}");
}
finally
{
    Console.WriteLine("Kết thúc chương trình tính điểm.");
}

//=====================

int[] x = { 1, 2, 3, 4, 5 };
Console.WriteLine(x[9]);