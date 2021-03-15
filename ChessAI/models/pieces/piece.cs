namespace ChessAI
{
    public abstract class Piece : IMovable
    {
        public Type Type { get; set; }
        public Tile StandingTile { get; set; }
        public byte AvailableMoves { get; set; }

        public void Move(Tile targetTile)
        {
            if(AvailableMoves >= targetTile.X - StandingTile.X && AvailableMoves >= targetTile.Y - StandingTile.Y){
                StandingTile = targetTile;
            }
        }
    }
}