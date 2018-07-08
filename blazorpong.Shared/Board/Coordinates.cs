//From https://github.com/exceptionnotfound/BattleshipModellingPractice

namespace blazorpong.Shared.GameObjects
{
    public class Coordinates
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordinates(int column, int row)
        {
            Row = row;
            Column = column;
        }

        public Coordinates() { }
    }
}