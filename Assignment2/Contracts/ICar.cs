namespace Assignment2.Contracts
{
    public interface ICar
    {
        string Model { get; }

        Engine Engine { get; }

        Cargo Cargo { get; }

        Tire[] Tires { get; }
    }
}
