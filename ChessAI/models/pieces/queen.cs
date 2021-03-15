namespace ChessAI
{
    public class Queen : Piece
    {
        public Queen(Tile tile)
        {
            this.Type = Type.Queen;
            this.StandingTile = tile;
        }
    }
}