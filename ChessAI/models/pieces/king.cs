namespace ChessAI
{
    public class King : Piece
    {
        public King(Tile tile)
        {
            this.Type = Type.King;
            this.StandingTile = tile;
        }
    }
}