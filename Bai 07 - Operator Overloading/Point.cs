using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double X, double Y)
    {
        this.X = X;
        this.Y = Y;
    }

    // Nạp chồng toán tử cộng (+)
    public static Point operator +(Point p, Point r)
    {
        return new Point(p.X + r.X, p.Y + r.Y);
    }

    // Nạp chồng toán tử cộng (-)
    public static Point operator -(Point p, Point r)
    {
        return new Point(p.X - r.X, p.Y - r.Y);
    }

    // Nạp chồng toán tử cộng (*)
    public static Point operator *(Point p, double scalar)
    {
        return new Point(p.X*scalar, p.Y * scalar);
    }

    // Nạp chồng toán tử cộng (*)
    public static Point operator *(double scalar, Point p)
    {
        return new Point(p.X * scalar, p.Y * scalar);
    }

    // Nạp chồng toán tử bằng (==)
    public static bool operator ==(Point v1, Point v2)
    {
        if (ReferenceEquals(v1, v2)) return true;
        if (v1 is null || v2 is null) return false;
        return v1.X == v2.X && v1.Y == v2.Y;
    }

    // Nạp chồng toán tử khác (!=) - BẮT BUỘC khi có ==
    public static bool operator !=(Point v1, Point v2)
    {
        return !(v1 == v2);
    }
        public override string ToString()
    {
        return $"{(X,Y)}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Point other)
            return this == other;
        return false;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode();
    }

}

