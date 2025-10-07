using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HocSinh2
{
    private double toan, ly, hoa, van, anh;

    // Indexer với string
    public double this[string mon]
    {
        get
        {
            switch (mon.ToLower())
            {
                case "toan": return toan;
                case "ly": return ly;
                case "hoa": return hoa;
                case "van": return van;
                case "anh": return anh;
                default: return -1;
            }
        }
        set
        {
            switch (mon.ToLower())
            {
                case "toan": toan = value; break;
                case "ly": ly = value; break;
                case "hoa": hoa = value; break;
                case "van": van = value; break;
                case "anh": anh = value; break;
            }
        }
    }
}
