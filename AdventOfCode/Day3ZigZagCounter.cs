namespace AdventOfCode
{
    public class Day3ZigZagCounter
    {
        private int _currentX;
        private int _layer;
        private bool goingUp = true;

        public Day3ZigZagCounter(int layer)
        {
            _layer = layer;
            _currentX = 1;
        }

        public int getNext()
        {
            var valueToReturn = _currentX;
            if (_currentX == _layer || _currentX == 0)
            {
                goingUp = !goingUp;
            }
            _currentX += goingUp ? 1 : -1;
            return valueToReturn;
        }
    }
}