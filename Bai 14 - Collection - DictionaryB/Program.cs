using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class EnglishVietnameseDictionary
{
    // Dictionary lưu trữ: Key = từ tiếng Anh (chữ thường), Value = nghĩa tiếng Việt
    static Dictionary<string, string> dictionary = new Dictionary<string, string>();

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Thêm một số từ mẫu
        InitializeSampleData();

        bool running = true;
        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddWord();
                    break;
                case "2":
                    LookupWord();
                    break;
                case "3":
                    DeleteWord();
                    break;
                case "4":
                    DisplayAllWords();
                    break;
                case "5":
                    SearchWords();
                    break;
                case "6":
                    ShowStatistics();
                    break;
                case "0":
                    Console.WriteLine("\nCảm ơn bạn đã sử dụng từ điển!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("\n Lựa chọn không hợp lệ!");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            }
        }
    }

    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine("         TỪ ĐIỂN ANH-VIỆT");
        Console.WriteLine("========================================");
        Console.WriteLine("1. Thêm từ mới");
        Console.WriteLine("2. Tra cứu nghĩa");
        Console.WriteLine("3. Xóa từ");
        Console.WriteLine("4. Hiển thị tất cả từ (A-Z)");
        Console.WriteLine("5. Tìm kiếm từ");
        Console.WriteLine("6. Thống kê");
        Console.WriteLine("0. Thoát");
        Console.WriteLine("========================================");
        Console.Write("Lựa chọn của bạn: ");
    }

    static void InitializeSampleData()
    {
        dictionary.Add("hello", "xin chào");
        dictionary.Add("world", "thế giới");
        dictionary.Add("book", "sách");
        dictionary.Add("computer", "máy tính");
        dictionary.Add("student", "sinh viên");
        dictionary.Add("teacher", "giáo viên");
        dictionary.Add("school", "trường học");
        dictionary.Add("friend", "bạn bè");
        dictionary.Add("family", "gia đình");
        dictionary.Add("love", "tình yêu");
    }

    static void AddWord()
    {
        Console.WriteLine("\n--- THEM TU MOI ---");
        Console.Write("Nhap tu tieng Anh: ");
        string englishWord = Console.ReadLine().Trim().ToLower();

        if (string.IsNullOrEmpty(englishWord))
        {
            Console.WriteLine("Loi: Tu khong duoc de trong!");
            return;
        }

        if (dictionary.ContainsKey(englishWord))
        {
            Console.WriteLine($"Tu '{englishWord}' da co trong tu dien!");
            Console.Write("Ban co muon cap nhat nghia? (y/n): ");
            string confirm = Console.ReadLine().ToLower();

            if (confirm != "y")
            {
                Console.WriteLine("Huy thao tac.");
                return;
            }
        }

        Console.Write("Nhap nghia tieng Viet: ");
        string vietnameseMeaning = Console.ReadLine().Trim();

        if (string.IsNullOrEmpty(vietnameseMeaning))
        {
            Console.WriteLine("Loi: Nghia khong duoc de trong!");
            return;
        }

        dictionary[englishWord] = vietnameseMeaning;
        Console.WriteLine($"Da them tu '{englishWord}' thanh cong!");
    }

    static void LookupWord()
    {
        Console.WriteLine("\n--- TRA CUU NGHIA ---");
        Console.Write("Nhap tu can tra: ");
        string word = Console.ReadLine().Trim().ToLower();

        if (dictionary.TryGetValue(word, out string meaning))
        {
            Console.WriteLine($"\n{word}: {meaning}");
        }
        else
        {
            Console.WriteLine($"\nKhong tim thay tu '{word}' trong tu dien.");
        }
    }

    static void DeleteWord()
    {
        Console.WriteLine("\n--- XOA TU ---");
        Console.Write("Nhap tu can xoa: ");
        string word = Console.ReadLine().Trim().ToLower();

        if (dictionary.ContainsKey(word))
        {
            Console.Write($"Ban co chac muon xoa tu '{word}'? (y/n): ");
            string confirm = Console.ReadLine().ToLower();

            if (confirm == "y")
            {
                dictionary.Remove(word);
                Console.WriteLine($"Da xoa tu '{word}' thanh cong!");
            }
            else
            {
                Console.WriteLine("Huy thao tac xoa.");
            }
        }
        else
        {
            Console.WriteLine($"Khong tim thay tu '{word}' trong tu dien.");
        }
    }

    static void DisplayAllWords()
    {
        Console.WriteLine("\n--- DANH SÁCH TẤT CẢ CÁC TỪ (A-Z) ---");

        if (dictionary.Count == 0)
        {
            Console.WriteLine("Từ điển hiện đang trống.");
            return;
        }

        // Sắp xếp theo thứ tự ABC
        var sortedWords = dictionary.OrderBy(x => x.Key);

        Console.WriteLine("\n{0,-20} {1}", "Từ tiếng Anh", "Nghĩa tiếng Việt");
        Console.WriteLine(new string('-', 60));

        int count = 1;
        foreach (var item in sortedWords)
        {
            Console.WriteLine($"{count}. {item.Key,-17} - {item.Value}");
            count++;
        }

        Console.WriteLine(new string('-', 60));
        Console.WriteLine($"Tổng cộng: {dictionary.Count} từ");
    }

    static void SearchWords()
    {
        Console.WriteLine("\n--- TIM KIEM TU ---");
        Console.Write("Nhap chuoi ky tu can tim: ");
        string searchTerm = Console.ReadLine().Trim().ToLower();

        if (string.IsNullOrEmpty(searchTerm))
        {
            Console.WriteLine("Chuoi tim kiem khong duoc de trong!");
            return;
        }

        var results = dictionary.Where(x => x.Key.Contains(searchTerm))
                                .OrderBy(x => x.Key)
                                .ToList();

        if (results.Count > 0)
        {
            Console.WriteLine($"\nTim thay {results.Count} tu chua '{searchTerm}':");
            Console.WriteLine("\n{0,-20} {1}", "Tu tieng Anh", "Nghia tieng Viet");
            Console.WriteLine(new string('-', 60));

            foreach (var item in results)
            {
                Console.WriteLine($"  {item.Key,-17} - {item.Value}");
            }
        }
        else
        {
            Console.WriteLine($"\nKhong tim thay tu nao chua '{searchTerm}'");
        }
    }

    static void ShowStatistics()
    {
        Console.WriteLine("\n--- THONG KE TU DIEN ---");
        Console.WriteLine($"Tong so tu: {dictionary.Count}");

        if (dictionary.Count > 0)
        {
            var longestWord = dictionary.Keys.OrderByDescending(x => x.Length).First();
            Console.WriteLine($"Tu dai nhat: {longestWord} ({longestWord.Length} ky tu)");

            var shortestWord = dictionary.Keys.OrderBy(x => x.Length).First();
            Console.WriteLine($"Tu ngan nhat: {shortestWord} ({shortestWord.Length} ky tu)");

            double avgLength = dictionary.Keys.Average(x => x.Length);
            Console.WriteLine($"Do dai trung binh: {avgLength:F2} ky tu");
        }
    }
}