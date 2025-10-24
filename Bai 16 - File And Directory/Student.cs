using System;
using System.Runtime.Serialization;
using System.Text.Json;

[Serializable]
public class SinhVien : ISerializable
{
    public int MaSV { get; set; }
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public double DiemTB { get; set; }
    public string Lop { get; set; }

    public SinhVien() { }

    // constructor đặc biệt cho quá trình Deserialize
    protected SinhVien(SerializationInfo info, StreamingContext context)
    {
        MaSV = info.GetInt32(nameof(MaSV));
        HoTen = info.GetString(nameof(HoTen));
        NgaySinh = info.GetDateTime(nameof(NgaySinh));
        DiemTB = info.GetDouble(nameof(DiemTB));
        Lop = info.GetString(nameof(Lop));
    }

    // phương thức Serialize dữ liệu
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue(nameof(MaSV), MaSV);
        info.AddValue(nameof(HoTen), HoTen);
        info.AddValue(nameof(NgaySinh), NgaySinh);
        info.AddValue(nameof(DiemTB), DiemTB);
        info.AddValue(nameof(Lop), Lop);
    }

    public override string ToString()
    {
        return $"{MaSV} - {HoTen} ({Lop}), ĐTB: {DiemTB:F1}, Ngày sinh: {NgaySinh:dd/MM/yyyy}";
    }

    // --- Tiện ích JSON ---
    public string ToJson()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true // ghi đẹp, dễ đọc
        };
        string json = JsonSerializer.Serialize(this, options);
        return json;
    }

    public static SinhVien FromJson(string json)
    {
        return JsonSerializer.Deserialize<SinhVien>(json);
    }
}
