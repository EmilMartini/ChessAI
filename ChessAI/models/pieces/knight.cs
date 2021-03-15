namespace ChessAI
{
    public class Knight : Piece
    {
        public Knight(Tile tile)
        {
            this.Type = Type.Knight;
            this.StandingTile = tile;
        }
    }
}