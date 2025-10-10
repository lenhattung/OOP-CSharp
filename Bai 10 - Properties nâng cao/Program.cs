BankAccount b1 = new BankAccount("Le Nhat Tung", "0001");
//b1.Balance = 100;
b1.Deposit(100);


HocSinh hs = new HocSinh();
hs[0] = 8.5;
hs[1] = 10.0;
hs[3] = 5.5;


HocSinh2 hs2 = new HocSinh2();
hs2["toan"] = 9.0;
hs2["ly"] = 9.2;

Console.WriteLine(hs2["van"]);
Console.WriteLine(hs2["ly"]);


RapPhim r1 = new RapPhim();
r1.TenRap = "01";
r1[0, 5] = true; // Đã có người đặt vé
r1[1, 3] = true;

if (r1[0, 5])
    Console.WriteLine("Ghế đã được đặt!");


