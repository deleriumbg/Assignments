using System;
using System.Collections.Generic;
using System.Linq;
using Assignment1.Contracts;

namespace Assignment1
{
    class Program
    {
        private const string ErrorMessage = "Invalid input!";

        static void Main(string[] args)
        {
            var people = AddPeople();
            PrintPeopleOlderThan30(people);
        }

        private static void PrintPeopleOlderThan30(HashSet<IPerson> people)
        {
            Console.WriteLine(string.Join(Environment.NewLine, people
                .Where(p => p.Age > 30)
                .OrderByDescending(p => p.Age)
                .Select(p => $"{p.Name} - {p.Age}")));
        }

        private static HashSet<IPerson> AddPeople()
        {
            var people = new HashSet<IPerson>();
            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] personInfo = Console.ReadLine()?.Split(' ');
                try
                {
                    if (personInfo != null)
                    {
                        string name = personInfo[0];
                        int age = int.Parse(personInfo[1]);
                        IPerson person = new Person(name, age);
                        people.Add(person);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(ErrorMessage);
                }
            }

            return people;
        }
    }
}
