using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vector2D
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Overloading +
    public static Vector2D operator +(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X+v2.X, v1.Y+v2.Y);
    }

    // Overloading -
    public static Vector2D operator -(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
    }

    // Nạp chồng toán tử nhân với số (*) 
    public static Vector2D operator *(Vector2D v, double scalar)
    {
        return new Vector2D(v.X * scalar, v.Y * scalar);
    }

    // Nạp chồng toán tử nhân với số (thứ tự ngược lại)
    public static Vector2D operator *(double scalar, Vector2D v)
    {
        return new Vector2D(v.X * scalar, v.Y * scalar);
    }
    // Override ToString để hiển thị đẹp
    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    // Nạp chồng toán tử bằng (==)
    public static bool operator ==(Vector2D v1, Vector2D v2)
    {
        if (ReferenceEquals(v1, v2)) return true;
        if (v1 is null || v2 is null) return false;
        return v1.X == v2.X && v1.Y == v2.Y;
    }


    // Nạp chồng toán tử khác (!=) - BẮT BUỘC khi có ==
    public static bool operator !=(Vector2D v1, Vector2D v2)
    {
        return !(v1 == v2);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Vector2D other)
            return this == other;
        return false;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode();
    }
}
