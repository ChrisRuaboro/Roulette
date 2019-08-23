using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    public class WheelPiece
    {
        public Color color;
        public int number;

        public WheelPiece()
        {

        }
        public WheelPiece(Color c, int n)
        {
            this.color = c;
            this.number = n;
        }
        public Color WheelPieceColor()
        {
            return this.color;
        }
        public int WheelPieceNum()
        {
            return this.number;
        }
    }
}
