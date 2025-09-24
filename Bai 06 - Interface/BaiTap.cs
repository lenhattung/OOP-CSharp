using System;

// Interface 1: Các chức năng cơ bản của phương tiện
public interface IVehicle
{
    void Start();
    void Stop();
    double GetFuelLevel();
}

// Interface 2: Các chức năng định vị và dẫn đường
public interface INavigable
{
    void SetDestination(string destination);
    void Navigate();
    string GetCurrentLocation();
}

// Interface 3: Các chức năng kết nối
public interface IConnectable
{
    void ConnectBluetooth();
    void ConnectWiFi();
    void DisconnectAll();
}

// Interface 4: Các chức năng bảo hiểm
public interface IInsurable
{
    string GetInsuranceInfo();
    void RenewInsurance();
    void ClaimInsurance();
}

// Class cha abstract
public abstract class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double FuelLevel { get; protected set; }

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
        FuelLevel = 50.0; // Mức nhiên liệu mặc định
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle: {Brand} {Model} ({Year})");
        Console.WriteLine($"Fuel Level: {FuelLevel:F1} liters");
    }

    public void AddFuel(double amount)
    {
        FuelLevel += amount;
        Console.WriteLine($"Đã thêm {amount} lít nhiên liệu");
    }

    // Phương thức abstract bắt buộc phải override
    public abstract void Move();
}

// Class Car - hiện thực tất cả 4 interface (xe hơi cao cấp)
public class Car : Vehicle, IVehicle, INavigable, IConnectable, IInsurable
{
    public int NumberOfDoors { get; set; }
    public bool HasAirCondition { get; set; }
    private string currentLocation = "Garage";
    private string destination = "";

    public Car(string brand, string model, int year, int doors, bool hasAC)
        : base(brand, model, year)
    {
        NumberOfDoors = doors;
        HasAirCondition = hasAC;
    }

    public override void Move()
    {
        Console.WriteLine($"{Brand} {Model} đang di chuyển êm ái trên đường");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Số cửa: {NumberOfDoors}");
        Console.WriteLine($"Có điều hòa: {(HasAirCondition ? "Có" : "Không")}");
    }

    // Hiện thực IVehicle
    public void Start()
    {
        Console.WriteLine($"{Brand} {Model} khởi động êm ru");
        FuelLevel -= 0.1;
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} {Model} dừng lại an toàn");
    }

    public double GetFuelLevel()
    {
        return FuelLevel;
    }

    // Hiện thực INavigable
    public void SetDestination(string destination)
    {
        this.destination = destination;
        Console.WriteLine($"Đã đặt đích đến: {destination}");
    }

    public void Navigate()
    {
        if (!string.IsNullOrEmpty(destination))
        {
            Console.WriteLine($"GPS đang dẫn đường đến {destination}");
            currentLocation = destination;
        }
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    // Hiện thực IConnectable
    public void ConnectBluetooth()
    {
        Console.WriteLine("Đã kết nối Bluetooth với điện thoại");
    }

    public void ConnectWiFi()
    {
        Console.WriteLine("Đã kết nối WiFi hotspot");
    }

    public void DisconnectAll()
    {
        Console.WriteLine("Đã ngắt tất cả kết nối");
    }

    // Hiện thực IInsurable
    public string GetInsuranceInfo()
    {
        return $"Bảo hiểm xe {Brand} {Model} - Hạn đến: 31/12/2025";
    }

    public void RenewInsurance()
    {
        Console.WriteLine("Đã gia hạn bảo hiểm xe ô tô");
    }

    public void ClaimInsurance()
    {
        Console.WriteLine("Đã gửi yêu cầu bồi thường bảo hiểm");
    }
}

// Class Motorcycle - hiện thực 3 interface (không có connectivity)
public class Motorcycle : Vehicle, IVehicle, INavigable, IInsurable
{
    public bool HasSidecar { get; set; }
    public int EngineSize { get; set; }
    private string currentLocation = "Parking";
    private string destination = "";

    public Motorcycle(string brand, string model, int year, bool hasSidecar, int engineSize)
        : base(brand, model, year)
    {
        HasSidecar = hasSidecar;
        EngineSize = engineSize;
    }

    public override void Move()
    {
        Console.WriteLine($"{Brand} {Model} đang phóng nhanh trên đường");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Có xe phụ: {(HasSidecar ? "Có" : "Không")}");
        Console.WriteLine($"Dung tích động cơ: {EngineSize}cc");
    }

    // Hiện thực IVehicle
    public void Start()
    {
        Console.WriteLine($"{Brand} {Model} nổ máy ầm ầm");
        FuelLevel -= 0.05;
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} {Model} dừng lại");
    }

    public double GetFuelLevel()
    {
        return FuelLevel;
    }

    // Hiện thực INavigable
    public void SetDestination(string destination)
    {
        this.destination = destination;
        Console.WriteLine($"Đã nhớ đích đến: {destination}");
    }

    public void Navigate()
    {
        if (!string.IsNullOrEmpty(destination))
        {
            Console.WriteLine($"Đang đi đến {destination} theo kinh nghiệm");
            currentLocation = destination;
        }
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    // Hiện thực IInsurable
    public string GetInsuranceInfo()
    {
        return $"Bảo hiểm xe máy {Brand} {Model} - Loại cơ bản";
    }

    public void RenewInsurance()
    {
        Console.WriteLine("Đã gia hạn bảo hiểm xe máy");
    }

    public void ClaimInsurance()
    {
        Console.WriteLine("Đã gửi đơn bồi thường tai nạn xe máy");
    }
}

// Class Truck - hiện thực 2 interface (xe tải cơ bản)
public class Truck : Vehicle, IVehicle, IConnectable
{
    public double LoadCapacity { get; set; }
    public double CurrentLoad { get; private set; }

    public Truck(string brand, string model, int year, double capacity)
        : base(brand, model, year)
    {
        LoadCapacity = capacity;
        CurrentLoad = 0;
    }

    public override void Move()
    {
        Console.WriteLine($"{Brand} {Model} đang chở hàng di chuyển chậm rãi");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Tải trọng tối đa: {LoadCapacity} tấn");
        Console.WriteLine($"Hàng hóa hiện tại: {CurrentLoad} tấn");
    }

    // Hiện thực IVehicle
    public void Start()
    {
        Console.WriteLine($"{Brand} {Model} khởi động động cơ diesel");
        FuelLevel -= 0.2;
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} {Model} dừng lại với tiếng phanh hơi");
    }

    public double GetFuelLevel()
    {
        return FuelLevel;
    }

    // Hiện thực IConnectable
    public void ConnectBluetooth()
    {
        Console.WriteLine("Đã kết nối Bluetooth với hệ thống quản lý đội xe");
    }

    public void ConnectWiFi()
    {
        Console.WriteLine("Đã kết nối WiFi để theo dõi GPS");
    }

    public void DisconnectAll()
    {
        Console.WriteLine("Đã ngắt kết nối tất cả thiết bị");
    }

    // Phương thức riêng cho xe tải
    public void LoadCargo(double weight)
    {
        if (CurrentLoad + weight <= LoadCapacity)
        {
            CurrentLoad += weight;
            Console.WriteLine($"Đã chất {weight} tấn hàng. Tổng: {CurrentLoad} tấn");
        }
        else
        {
            Console.WriteLine("Không thể chất thêm hàng - vượt quá tải trọng!");
        }
    }

    public void UnloadCargo()
    {
        CurrentLoad = 0;
        Console.WriteLine("Đã dỡ hết hàng hóa");
    }
}

// Chương trình chính
class Program
{
    static void Main()
    {
        Console.WriteLine("=== VÍ DỤ KẾ THỪA VÀ NHIỀU INTERFACE TRONG C# ===\n");

        // Tạo xe ô tô (có tất cả tính năng)
        Car luxuryCar = new Car("Mercedes", "S-Class", 2023, 4, true);
        Console.WriteLine("--- XE Ô TÔ CAO CẤP ---");
        luxuryCar.DisplayInfo();
        luxuryCar.Start();
        luxuryCar.ConnectBluetooth();
        luxuryCar.SetDestination("Sân bay Tân Sơn Nhất");
        luxuryCar.Navigate();
        Console.WriteLine($"Vị trí hiện tại: {luxuryCar.GetCurrentLocation()}");
        Console.WriteLine(luxuryCar.GetInsuranceInfo());
        Console.WriteLine();

        // Tạo xe máy (không có connectivity)
        Motorcycle sportBike = new Motorcycle("Yamaha", "R1", 2022, false, 1000);
        Console.WriteLine("--- XE MÁY THỂ THAO ---");
        sportBike.DisplayInfo();
        sportBike.Start();
        sportBike.SetDestination("Quận 1");
        sportBike.Navigate();
        Console.WriteLine(sportBike.GetInsuranceInfo());
        Console.WriteLine();

        // Tạo xe tải (chỉ có chức năng cơ bản)
        Truck deliveryTruck = new Truck("Isuzu", "NPR", 2023, 5.0);
        Console.WriteLine("--- XE TÁI GIAO HÀNG ---");
        deliveryTruck.DisplayInfo();
        deliveryTruck.LoadCargo(2.5);
        deliveryTruck.Start();
        deliveryTruck.ConnectWiFi();
        deliveryTruck.Move();
        deliveryTruck.UnloadCargo();
        Console.WriteLine();

        // Sử dụng Interface Polymorphism
        Console.WriteLine("--- SỬ DỤNG INTERFACE POLYMORPHISM ---");

        // Tất cả đều implement IVehicle
        IVehicle[] vehicles = { luxuryCar, sportBike, deliveryTruck };
        Console.WriteLine("Khởi động tất cả phương tiện:");
        foreach (IVehicle vehicle in vehicles)
        {
            vehicle.Start();
        }
        Console.WriteLine();

        // Chỉ xe có thể navigate
        INavigable[] navigableVehicles = { luxuryCar, sportBike };
        Console.WriteLine("Dẫn đường cho các phương tiện có GPS:");
        foreach (INavigable nav in navigableVehicles)
        {
            nav.SetDestination("Bến Thành Market");
            nav.Navigate();
        }
        Console.WriteLine();

        // Chỉ xe có thể kết nối
        IConnectable[] connectableVehicles = { luxuryCar, deliveryTruck };
        Console.WriteLine("Kết nối các thiết bị thông minh:");
        foreach (IConnectable conn in connectableVehicles)
        {
            conn.ConnectBluetooth();
        }
    }
}