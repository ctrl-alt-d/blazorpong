using System.Collections.Generic;

namespace blazorpong.Shared.GameObjects
{
    /// <summary>
    /// Represents a collection of Panels to provide a Player with their Game Board (e.g. where their ships are placed).
    /// </summary>
    public class GameBoard
    {
        public List<Tile> Tiles { get; set; }

        public const int  MAX_COL = 40;
        public const int  MAX_ROW = 80;

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
        }
    }
}
