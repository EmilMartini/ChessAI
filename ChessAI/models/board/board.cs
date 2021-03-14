using System;

namespace ChessAI
{
    public class Board
    {
        public Tile[,] Tiles { get; set; }
        public Piece[] BlackPieces { get; set; }
        public Piece[] WhitePieces { get; set; }

        public Board(byte boardSize)
        {
            Tiles = new Tile[boardSize, boardSize];
            BlackPieces = new Piece[16];
            WhitePieces = new Piece[16];

            Tiles = InitTiles(Tiles);
            BlackPieces = InitPieces(Tiles, BlackPieces, true);
            WhitePieces = InitPieces(Tiles, WhitePieces, false);
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

        private Piece[] InitPieces(Tile[,] tiles, Piece[] pieces, bool isBlack)
        {
            if (isBlack)
            {
                for (byte y = 0; y < 2; y++)
                {
                    for (byte x = 0; x < tiles.GetLength(1); x++)
                    {
                        if(y == 1){
                            pieces[y+x] = new Rook(tiles[y,x]);
                        }
                    }
                }
            }
            else
            {
            }

            return null;
        }
    }
}