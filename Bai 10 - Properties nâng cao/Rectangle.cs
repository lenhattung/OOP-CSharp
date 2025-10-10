using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    // Computed property - chỉ get
    public double Area => Width * Height;

    // Computed property với cấu trúc đầy đủ
    public double Perimeter
    {
        get { return 2 * (Width + Height); }
    }

    // Property với validation
    private double _diagonal;
    public double Diagonal
    {
        get => Math.Sqrt(Width * Width + Height * Height);
        set
        {
            if (value < 0)
                throw new ArgumentException("Diagonal cannot be negative");
            _diagonal = value;
        }
    }
}
