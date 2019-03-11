namespace Assignment2
{
    public class Engine
    {
        private int _speed;
        private readonly int _power;

        public Engine(int speed, int power)
        {
            this._speed = speed;
            this._power = power;
        }

        public int Power => this._power;
    }
}
