using Assignment1.Contracts;

namespace Assignment1
{
    public class Person : IPerson
    {
        private const string DefaultName = "No name";
        private const int DefaultAge = 1;
        private string _name;
        private int _age;

        public Person()
        {
            this.Name = DefaultName;
            this.Age = DefaultAge;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(string name, int age) : this(age)
        {
            this.Name = name;
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    //throw new ArgumentException("Name cannot be null or whitespace!");
                    value = DefaultName;
                }
                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            private set
            {
                if (value < 0)
                {
                    //throw new ArgumentException("Age cannot be negative!");
                    value = DefaultAge;
                }
                _age = value;
            }
        }
    }
}
