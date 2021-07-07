namespace TreehouseDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y) : base(x, y)
        {
            if (!MapLocation.onMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundaries  of the map.");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}