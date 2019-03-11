namespace Assignment2
{
    public class Cargo
    {
        private int _weight;
        private readonly string _type;

        public Cargo(int weight, string type)
        {
            this._weight = weight;
            this._type = type;
        }

        public string Type => this._type;
    }
}
