namespace ChessAI
{
    public class Rook : Piece
    {
        public Rook(Tile tile)
        {
            this.Type = Type.Rook;
            this.StandingTile = tile;
        }
    }
}