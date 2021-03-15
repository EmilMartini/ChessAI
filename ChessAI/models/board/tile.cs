using System;

namespace ChessAI
{
    public class Tile
    {
        public byte X { get; private set; }
        public byte Y { get; private set; }
        public string Color { get; private set; }
        public bool IsEmpty { get; set; }

        public Tile(byte y, byte x)
        {
            this.X = x;
            this.Y = y;
            this.Color = (x + y) % 2 == 1 ? "#769656" : "#eeeed2";
        }
    }
}