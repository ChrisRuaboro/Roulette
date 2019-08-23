using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    public enum Color { red, black, green }
    public class Wheel
    {
        static Random rnd = new Random();
        static List<WheelPiece> board = new List<WheelPiece>();
        static WheelPiece randomPiece;

        public WheelPiece RandomPiece
        {
            get =>
                board[rnd.Next(board.Count)];
            set => RandomPiece = value;
        }
        public List<WheelPiece> Board
        {
            get => board; set => Board = board;
        }


        public Wheel()
        {
            generateReds();
            generateBlacks();
            generateGreens();
            randomPiece = board[rnd.Next(board.Count)];
        }

        static void generateReds()
        {
            foreach (int num in Bets.reds)
            {
                board.Add(new WheelPiece(Color.red, num));
            }
        }
        static void generateBlacks()
        {
            foreach (int num in Bets.blacks)
            {
                board.Add(new WheelPiece(Color.black, num));
            }
        }
        static void generateGreens()
        {
            foreach (int num in Bets.greens)
            {
                board.Add(new WheelPiece(Color.green, num));
            }
        }
    }
}