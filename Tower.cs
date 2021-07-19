namespace TreehouseDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }
    }
}