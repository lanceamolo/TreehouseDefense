namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        //fat arrow notation
        public MapLocation Location => _path.GetLocationAt(_pathStep);

        //curly bracket notation
        public bool HasScored { get { return _pathStep >= _pathStep.Length; } }

        public int Health { get; private set; } = 2;

        public bool IsNeutralized => Health <= 0;

        public bool IsActive !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        //single line method syntax () =>
        publc void Move() => _pathStep += 1;

        //traditional method syntax () {}
        public void DecreaseHealth(int factor)
        {
            Health -= factor;
        }

    }
}