namespace Assignment3.Models
{
    public struct SeatLocation
    {
        public char Row { get; }
        public int Number { get; }

        public SeatLocation(char row, int number)
        {
            Row = row;
            Number = number;
        }

        // Formats as "A-5", "B-10"
        public override string ToString() => $"{Row}-{Number}";
    }
}