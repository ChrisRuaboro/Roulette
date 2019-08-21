using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    interface Iattributes
    {
        bool isEven(int Number);
        bool isLows(int Number);
        bool isStreets(int Number);
        bool isDozens(int Number);
        bool isColumns(int Number);
        bool sixNums(int Number);
        bool isSplits(int Number);
        bool isCorners(int Number);

        //Color color { get; set; }
        //bool isEven { get; set; }
        //bool isLows { get; set; }
        //bool isStreets { get; set; }
        //bool isDozens { get; set; }
        //bool isColumns { get; set; }
        //bool sixNums { get; set; }
        //bool isSplits { get; set; }
        //bool isCorners { get; set; }
    }
}
