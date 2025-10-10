using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RapPhim
{
    public string TenRap { get;set; }

    private bool[,] ghe = new bool[5, 10]; // 5 hàng, 10 ghế


    // Indexer với 2 tham số
    public bool this[int hang, int cot]
    {
        get
        {
            if (hang >= 0 && hang < 5 && cot >= 0 && cot < 10)
                return ghe[hang, cot];
            return false;
        }
        set
        {
            if (hang >= 0 && hang < 5 && cot >= 0 && cot < 10)
                ghe[hang, cot] = value;
        }
    }

}
