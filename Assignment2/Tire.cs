namespace Assignment2
{
    public class Tire
    {
        private readonly double _pressure;
        private int _age;

        public Tire(double pressure, int age)
        {
            this._pressure = pressure;
            this._age = age;
        }

        public double Pressure => this._pressure;
    }
}
