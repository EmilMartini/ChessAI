namespace ChessAI
{
    public class GameplayManager
    {
        public Board Board { get; set; }
        public Piece[] BlackPieces { get; set; }
        public Piece[] WhitePieces { get; set; }

        public void CreateGame()
        {
            this.Board = new Board(8);

            this.BlackPieces = InitPieces(Board.Tiles, new Piece[16], true);
            this.WhitePieces = InitPieces(Board.Tiles, new Piece[16], false);
        }

        private Piece[] InitPieces(Tile[,] tiles, Piece[] pieces, bool isBlack)
        {
            var newPieces = new Piece[pieces.Length];
            if (isBlack)
            {
                for (byte y = 0; y < 2; y++)
                {
                    for (byte x = 0; x < 8; x++)
                    {
                        if (y == 1)
                        {
                            newPieces[y + (x + 7)] = new Pawn(tiles[y, x]);
                        }
                        else
                        {
                            if (x == 0 || x == 7)
                            {
                                newPieces[x + y] = new Rook(tiles[y, x]);
                            }
                            if (x == 1 || x == 6)
                            {
                                newPieces[x + y] = new Knight(tiles[y, x]);
                            }
                            if (x == 2 || x == 5)
                            {
                                newPieces[x + y] = new Bishop(tiles[y, x]);
                            }
                            if (x == 3)
                            {
                                newPieces[x + y] = new King(tiles[y, x]);
                            }
                            if (x == 4)
                            {
                                newPieces[x + y] = new Queen(tiles[y, x]);
                            }
                        }
                    }
                }
            }
            else
            {
                for (int y = tiles.GetLength(0) - 1; y > 5; y--)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        if (y == 6)
                        {
                            newPieces[x] = new Pawn(tiles[y, x]);
                        }
                        else
                        {
                            if (x == 0 || x == 7)
                            {
                                newPieces[x + y + 1] = new Rook(tiles[y, x]);
                            }
                            if (x == 1 || x == 6)
                            {
                                newPieces[x + y + 1] = new Knight(tiles[y, x]);
                            }
                            if (x == 2 || x == 5)
                            {
                                newPieces[x + y + 1] = new Bishop(tiles[y, x]);
                            }
                            if (x == 3)
                            {
                                newPieces[x + y + 1] = new King(tiles[y, x]);
                            }
                            if (x == 4)
                            {
                                newPieces[x + y + 1] = new Queen(tiles[y, x]);
                            }
                        }
                    }
                }
            }
            return newPieces;
        }
    }
}