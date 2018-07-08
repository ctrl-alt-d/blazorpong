using System.Collections.Generic;
using System.Linq;
using System;

namespace blazorpong.Shared.GameObjects
{
    /// <summary>
    /// Represents a collection of Panels to provide a Player with their Game Board (e.g. where their ships are placed).
    /// </summary>
    public class GameBoard
    {
        public Tile[,] Tiles { get; set; }
        public Ball Ball { get; private set; }

        public const int  MAX_COL = 40;
        public const int  MAX_ROW = 80;

        public GameBoard()
        {
            Tiles = new Tile[MAX_COL, MAX_ROW];
            for (int col = 0; col < MAX_COL; col++)
            {
                for (int row = 0; row < MAX_ROW; row++)
                {
                    Tiles[col,row] = new Tile(col, row);
                }
            }

            Ball = new Ball(new Coordinates(MAX_COL / 2, MAX_ROW / 2));
        }

        public string GetClass(int column, int row)
        {
            return GetClass( new Coordinates(column, row));
        }

        public string GetClass(Coordinates coordinates)
        {
            return (Ball.Coordinates.Equals(coordinates)) ? "tile-green" : "tile-white";
        }

        public string TileBallId() {
            return this.Tiles[ this.Ball.Coordinates.Column, this.Ball.Coordinates.Row ]?.Id;
        }

        public string GetTileId(int Column, int Row) {
            return this.Tiles[ Column, Row ]?.Id;
        }
    }
}
