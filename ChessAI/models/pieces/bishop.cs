namespace ChessAI
{
    public class Bishop : Piece
    {
        public Bishop(Tile tile)
        {
            this.Type = Type.Bishop;
            this.StandingTile = tile;
        }
    }
}