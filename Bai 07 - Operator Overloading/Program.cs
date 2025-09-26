Vector2D v1 = new Vector2D(3, 4);
Vector2D v2 = new Vector2D(1, 2);

Vector2D sum = v1 + v2;        // Kết quả: (4, 6)
Vector2D diff = v1 - v2;       // Kết quả: (2, 2)
Vector2D scaled = v1 * 2;      // Kết quả: (6, 8)
Vector2D scaled2 = 3 * v1;     // Kết quả: (9, 12)

Console.WriteLine($"v1 + v2 = {sum}");
Console.WriteLine($"v1 - v2 = {diff}");
Console.WriteLine($"v1 * 2 = {scaled}");

Console.WriteLine(v1 == v2);


Vector2D v3 = new Vector2D(3, 4);
Vector2D v4 = new Vector2D(3, 4);
Vector2D v5 = new Vector2D(1, 2);

Console.WriteLine(v3 == v4); // True
Console.WriteLine(v4 != v5); // True

/*
+ Toán tử BẮT BUỘC cặp đôi:
    == và !=
    > và <
    >= và <=
    true và false

+ Toán tử KHÔNG thể nạp chồng:
    = (gán)
    &&, || (logic)
    [] (indexer - có cách khác)
    () (cast - có cách khác)
    new, is, as, typeof
*/