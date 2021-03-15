namespace ChessAI
{
    public class Pawn : Piece
    {
        public Pawn(Tile tile)
        {
            this.Type = Type.Pawn;
            this.StandingTile = tile;
        }
    }
}