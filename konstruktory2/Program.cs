using System;
using konstruktory2.classess;
namespace konstruktory2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p0 = new Person();
            Person p1 = new Person("Jan");
            Person p2 = new Person("Jan", "Nowak");
            Person p3 = new Person("Jan", "Nowak", 20);
            Person p4 = new Person("Jan", "Nowak", 20, 175.5f);
            /*Console.WriteLine($"Ilość obiektów klasy Person: {Person.Counter}");*/
            List<Person> people = new List<Person>();
            /*people.Add(p0);
            people.Add(p1);
            people.Add(p2);
            people.Add(p3);
            people.Add(p4);*/
            people.AddRange(new[] { p0, p1, p2, p3, p4 });
            Console.WriteLine($"Ilość obiektów klasy Person: {people.Count}");
            Console.ReadKey();
        }
    }
}