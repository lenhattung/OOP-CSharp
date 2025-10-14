/*
 ================================================================================
                    DE BAI: QUAN LY SAN PHAM SU DUNG ARRAYLIST
================================================================================

-------------------------------------------------------------------------------
PHAN 1: TAO CLASS PRODUCT (1 diem)
-------------------------------------------------------------------------------

Tao class Product voi cac thuoc tinh:
- Id (int): Ma san pham
- Name (string): Ten san pham
- Price (double): Gia san pham
- Quantity (int): So luong trong kho

YEU CAU:
1. Constructor day du tham so
2. Override ToString() de hien thi thong tin
3. Override Equals() de so sanh theo Id (cho Contains())
4. Override GetHashCode()
5. Implement IComparable de sap xep theo gia tang dan (cho Sort())

-------------------------------------------------------------------------------
PHAN 2: TAO CLASS PRODUCTMANAGER (10 diem)
-------------------------------------------------------------------------------

Tao class ProductManager su dung ArrayList de quan ly danh sach san pham.

CAC PHUONG THUC CAN IMPLEMENT:

1. THEM SAN PHAM (2 diem)
   public void AddProduct(Product product)
   
   - Kiem tra Id da ton tai chua (dung Contains())
   - Neu chua co -> them vao
   - Neu da co -> thong bao loi

2. HIEN THI TAT CA SAN PHAM (1 diem)
   public void DisplayAll()
   
   - In ra console theo dinh dang bang dep
   - Hien thi: Id, Name, Price, Quantity, Total Value

3. TIM SAN PHAM THEO ID (1 diem)
   public Product FindById(int id)
   
   - Duyet ArrayList tim san pham
   - Tra ve san pham neu tim thay, null neu khong

4. TIM SAN PHAM THEO TEN (1 diem)
   public ArrayList FindByName(string keyword)
   
   - Tim tat ca san pham co ten chua keyword (khong phan biet hoa/thuong)
   - Tra ve ArrayList chua ket qua

5. XOA SAN PHAM THEO ID (1 diem)
   public bool RemoveProduct(int id)
   
   - Tim va xoa san pham
   - Tra ve true neu xoa thanh cong, false neu khong tim thay

6. CAP NHAT SO LUONG (1 diem)
   public void UpdateQuantity(int id, int newQuantity)
   
   - Tim san pham theo Id
   - Cap nhat so luong moi

7. SAP XEP THEO GIA (1 diem)
   public void SortByPrice()
   
   - Su dung ArrayList.Sort() de sap xep theo gia

8. LOC SAN PHAM THEO GIA (1 diem)
   public ArrayList FilterByPrice(double minPrice, double maxPrice)
   
   - Tra ve danh sach san pham co gia trong khoang [minPrice, maxPrice]

9. TINH TONG GIA TRI KHO (0.5 diem)
   public double CalculateTotalValue()
   
   - Tinh tong: Price x Quantity cua tat ca san pham

10. THONG KE (0.5 diem)
    public void ShowStatistics()
    
    - Tong so san pham
    - San pham dat nhat
    - San pham re nhat
    - Tong gia tri kho

-------------------------------------------------------------------------------
PHAN 3: TAO MENU TRONG MAIN() (1 diem)
-------------------------------------------------------------------------------

Tao menu console voi cac chuc nang:

=== QUAN LY SAN PHAM ===
1. Them san pham
2. Hien thi tat ca san pham
3. Tim san pham theo ID
4. Tim san pham theo ten
5. Xoa san pham
6. Cap nhat so luong
7. Sap xep theo gia
8. Loc san pham theo khoang gia
9. Thong ke
0. Thoat

Chon chuc nang:

-------------------------------------------------------------------------------
DU LIEU MAU
-------------------------------------------------------------------------------

Them san 5 san pham mau:
1. Laptop Dell, 15000000, 5
2. Mouse Logitech, 250000, 20
3. Keyboard Corsair, 800000, 15
4. Monitor Samsung, 3500000, 8
5. Headphone Sony, 1200000, 12


 */