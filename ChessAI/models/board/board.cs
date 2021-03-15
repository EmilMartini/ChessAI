
namespace ChessAI
{
    public class Board
    {
        public Tile[,] Tiles { get; set; }

        public Board(byte boardSize)
        {
            Tiles = new Tile[boardSize, boardSize];

            Tiles = InitTiles(Tiles);
        }

        private Tile[,] InitTiles(Tile[,] tiles)
        {
            for (byte y = 0; y < tiles.GetLength(0); y++)
            {
                for (byte x = 0; x < tiles.GetLength(1); x++)
                {
                    tiles[x, y] = new Tile(x, y);
                }
            }
            return tiles;
        }       
    }
}