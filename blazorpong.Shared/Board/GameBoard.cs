using System.Collections.Generic;
using System.Linq;

namespace blazorpong.Shared.GameObjects
{
    /// <summary>
    /// Represents a collection of Panels to provide a Player with their Game Board (e.g. where their ships are placed).
    /// </summary>
    public class GameBoard
    {
        public List<Tile> Tiles { get; set; }
        public Ball Ball { get; private set; }

        public const int  MAX_COL = 4;
        public const int  MAX_ROW = 8;

        public GameBoard()
        {
            Tiles = new List<Tile>();
            for (int col = 1; col <= MAX_COL; col++)
            {
                for (int row = 1; row <= MAX_ROW; row++)
                {
                    Tiles.Add(new Tile(col, row));
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
            return Tiles
                  .Where( x=> x.Coordinates.Column == Ball.Coordinates.Column && x.Coordinates.Row == Ball.Coordinates.Row)
                  .FirstOrDefault()?
                  .Id;
        }

        public string GetTileId(int Column, int Row) {
            return Tiles
                  .Where( x=> x.Coordinates.Column == Column && x.Coordinates.Row == Row)
                  .FirstOrDefault()?
                  .Id;
        }
    }
}
