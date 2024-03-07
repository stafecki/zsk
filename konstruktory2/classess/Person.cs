using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktory2.classess
{
    internal class Person
    {
        //statyczne pola które przechowuje liczbę obieków klasy person
        public static int Counter = 0;

        //właściwości
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }

        /*konstruktor statyczne - jest on wywoływany automatycznie aby zainicjowac klasę przed utworzeniem pierszej instancji.
        Konstruktor statyczny jest wywoływany tylko raz przed pierwszym użyciem.
        Nie może mieć parametrów ani modyfikatorów dostępu
        Służy do inicjowania pól statycznych lub wykonywania innych operacji statycznych(wykonywanie kodu który jest związany z klasą a nie z jej obiektami np. ustawianie wartości domyślnych dla pól statycznych)*/
        static Person()
        {
            Console.WriteLine("Statyczny konstruktor klasy Person\n");
            //Counter++;
        }

        //konstruktor domyślny jest bezparametrowy. Jeśłi klasa nie ma żadnego konstruktora parametrycznego, to konstruktor domyślny jest wywoływany przy tworzeniu obiektu. Inicjuje on wszystkie pola do ich wartości domyślnych. Jeśli zdefiniujemy jakiś konstruktor parametryczny, to nie otrzymamy automatycznie konstruktora domyślnego i możemy/musimy go samodzielnie zadeklarować
        public Person()
        {
            Console.WriteLine("Konstruktor domyślny klasy Person");
            Counter++;
        }
        //konstruktor parametryczny ma co najmniej jeden parametr. Służy do inicjowania pól obiektu zgodnie z wartościami podanymi przy tworzeniu obiektu. Możemy mieć wiele konstruktorów parametrycznych, o ile różnią się liczbą lub/i typem parametrów 

        //konstruktor parametryczny klasy person z jednym parametrem
        public Person(string name)
        {
            Console.WriteLine("Konstruktor parametryczny z jednym parametrem");
            Name = name;
            Counter++;
        }

        //konstruktor klasy Person z dwoma parametrami
        public Person(string name, string surname)
        {
            Console.WriteLine("Konstruktor parametryczny z dwoma parametrami");
            Name = name;
            Surname = surname;
            Counter++;
        }

        //konstruktor klasy Person z trzema parametrami
        //this służy do wywołania innego konstruktora tej samej klasy, cyzli konstruktora z dwoma parametrami. Dzięki temu konstruktor z trzema parametrami nie musi inicjować pól Name, Surname a może skupić się na dodaniu pola Age. Jest to sposób na uniknięcie powtarzania kodu i zapewnienie spójności danych
        public Person(string name, string surname, int age) : this(name, surname) 
        {
            Console.WriteLine("Konstruktor parametryczny z trzema parametrami");
            Age = age;
            Counter++;
        }

        //konstruktor klasy Person z czterema parametrami
        public Person(string name, string surname, int age, float height) : this(name, surname, age)
        {
            Console.WriteLine("Konstruktor parametryczny z czterema parametrami");
            Height = height;
            Counter++;
        }
    }
}