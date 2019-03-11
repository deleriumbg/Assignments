using System;
using Assignment2.Contracts;

namespace Assignment2
{
    public class Car : ICar
    {
        private const string IncorrectNumberOfTires = "Number of tires should be exactly 4!";
        private readonly string _model;
        private readonly Engine _engine;
        private readonly Cargo _cargo;
        private readonly Tire[] _tires;

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            if (tires.Length != 4)
            {
                throw new InvalidOperationException(IncorrectNumberOfTires);
            }

            this._model = model;
            this._engine = engine;
            this._cargo = cargo;
            this._tires = tires;
        }

        public string Model => this._model;

        public Engine Engine => this._engine;

        public Cargo Cargo => this._cargo;

        public Tire[] Tires => this._tires;
    }
}
