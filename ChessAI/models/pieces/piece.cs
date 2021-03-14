namespace ChessAI
{
    public abstract class Piece
    {
        public Type Type { get; set; }
        public Tile StandingTile {get;set;}
    }
}