using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktory.classess
{
    internal class Person
    {
        //statyczne pola które przechowuje liczbę obieków klasy person
        public static int Counter = 0;

        //właściwości
        public string Name {  get; set; }
        public string Surname { get; set; }

        /*konstruktor statyczne - jest on wywoływany automatycznie aby zainicjowac klasę przed utworzeniem pierszej instancji.
        Konstruktor statyczny jest wywoływany tylko raz przed pierwszym użyciem.
        Nie może mieć parametrów ani modyfikatorów dostępu
        Służy do inicjowania pól statycznych lub wykonywania innych operacji statycznych(wykonywanie kodu który jest związany z klasą a nie z jej obiektami np. ustawianie wartości domyślnych dla pól statycznych)*/
        static Person()
        {
            Console.WriteLine("Statyczny konstruktor klasy Person");
            Counter++;
        }

        //konstruktor domyślny - 
        /*public Person()
        {
            Console.WriteLine("Konstruktor domyślny klasy Person");
        }*/

        //konstruktor parametryczny
        public Person(string name)
        {
            Name = name;
        }
    }
}
