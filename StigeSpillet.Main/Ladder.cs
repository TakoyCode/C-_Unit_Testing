namespace StigeSpilletTDD.Main
{
    internal class Ladder
    {
        public int PositionFrom { get; }
        public int PositionTo { get; }

        public Ladder(int positionFrom, int positionTo)
        {
            PositionFrom = positionFrom;
            PositionTo = positionTo;
        }
    }
}
