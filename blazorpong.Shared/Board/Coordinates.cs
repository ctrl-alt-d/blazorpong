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

        public override bool Equals(object obj)
        {
            Coordinates that = (Coordinates) obj;
            return (Row == that.Row && Column == that.Column);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Column} - {Row}";
        }
    }
}
