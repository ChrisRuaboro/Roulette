using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    public class Board : Bets , Iattributes
    {
        static int number = 0;
        public static int SpinWheel()
        {
            Random r = new Random();
            number = numbers[r.Next(0, numbers.Length)];
            return number;
        }
        public Color color {get => getColor(number);set => color = value;}
        public bool? even { get=>isEven(number); set=>even=value; }
        public bool? low { get => isLows(number); set => low = value; }

        static Color getColor(int number)
        {
            Color color = new Color();
            if (number == 0 || number == 37)
            {
                color = Color.green;
                return color;
            }
            foreach (var element in reds)
            {
                if (element == number)
                {
                    color = Color.red;
                }
                else
                {
                    color = Color.black;
                }
            }
            
            return color;
        }
        static bool? isEven(int number)
        {
            bool? even;
            if (number == 0 || number == 37)
            {
                even = null;
                return even;
            }
            foreach (var element in evens)
            {
                if (element == number)
                {
                    even = true;
                }
                else
                {
                    even = false;
                }
            }
            return even;

        }
        static bool isLows(int number)
        {

        }
        static bool isStreets(int number)
        {

        }
        static bool isDozens(int number)
        {

        }
        static bool isColumns(int number)
        {

        }
        static bool isSixNums(int number)
        {

        }
        static bool isSplits(int number)
        {

        }
        static bool isCorners(int number)
        {

        }




    }

}
