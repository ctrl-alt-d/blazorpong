//From https://github.com/exceptionnotfound/BattleshipModellingPractice
using System;
using System.ComponentModel;
using blazorpong.Shared.Helpers;

namespace blazorpong.Shared.GameObjects
{

    public class Tile
    {
        public OccupationType OccupationType { get; set; }
        public Coordinates Coordinates { get; set; }
        public string Id { get; private set; }
        public string CssClass { get; set; }

        public Tile(int column, int row)
        {
            Coordinates = new Coordinates(column, row);
            OccupationType = OccupationType.Empty;
            Id = Guid.NewGuid().ToString();
            CssClass = "tile-white";
        }

        public Tile() { }

        public string Status
        {
            get
            {
                return OccupationType.GetAttributeOfType<DescriptionAttribute>().Description;
            }
        }

        public bool IsOccupied
        {
            get
            {
                return OccupationType == OccupationType.Ball
                    || OccupationType == OccupationType.Paddle;
            }
        }

    }
}
