using System;

// Struct phù hợp cho Point vì:
// - Dữ liệu nhỏ (2 số)
// - Bất biến (immutable)
// - Sử dụng như primitive types
public struct Point2D
{
    public double X { get; }
    public double Y { get; }

    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Method tính khoảng cách
    public double DistanceTo(Point2D other)
    {
        double dx = X - other.X;
        double dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    // Override ToString
    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    // Override Equals cho struct
    public override bool Equals(object obj)
    {
        if (obj is Point2D other)
            return X == other.X && Y == other.Y;
        return false;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode();
    }
}