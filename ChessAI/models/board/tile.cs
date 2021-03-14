using System;

namespace ChessAI 
{
    public class Tile 
    {
        public byte X {get; private set;}
        public byte Y {get; private set;}
        public string Color {get; private set;}

        public Tile(byte x, byte y)
        {
            this.X = x;
            this.Y = y;        
            this.Color = (x + y) % 2 == 1 ? "Black" : "White";
        }
    }
}