﻿using System;
using System.Linq;

namespace lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt("Podaj liczbę osób: ", 0, int.MaxValue);
            string[] names = new string[n];
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = ReadString($"Podaj imie osoby {i + 1}: ");
                ages[i] = ReadInt($"Podaj wiek osoby {i + 1}: ", 0, 120);
            }

            List<string> namesThatStartsWithA = names.Where(name => name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

            /*Dictionary<string, int> adults = names.Zip(ages, (name, age) => new { name, age })
                .Where(person => person.age >= 18)
                .ToDictionary(person => person.name, person => person.age);*/

            Dictionary<string, int> adults = new Dictionary<string, int>();
            for (int i = 0;i < n; i++)
            {
                if (ages[i] >= 18)
                {
                    adults.Add(names[i], ages[i]);
                }
            }

            Console.WriteLine("Tablica imion i wiekow: ");
            PrintArray(names, ages);
            Console.WriteLine();

            Console.WriteLine("Lista osob z imieniem zaczynającym sie na \"a\":  ");
            PrintList(namesThatStartsWithA);
            Console.WriteLine();

            Console.WriteLine("Lista osob dorosłych: ");
            PrintDictionary(adults);
            Console.WriteLine();



        }
        static int ReadInt(string prompt, int low, int high)
        {
            int result;
            bool valid;
            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out result) && result >= low & result <= high;
                if (!valid)
                {
                    Console.WriteLine($"Podaj liczbę z zakresu <{low};{high}>");
                }

            } while (!valid);
            return result;
        }

        static string ReadString(string prompt)
        {
            string result;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result))
                {
                    Console.WriteLine("Podaj niepusty ciąg znaków");
                }
            } while (string.IsNullOrEmpty(result));
            return result;
        }

        static void PrintArray(string[] names, int[] ages)
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} - {ages[i]}");
            }
        }

        static void PrintList(List<string> names)
        {
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void PrintDictionary(Dictionary<string, int> adults)
        {
            foreach(var adult in adults)
            {
                Console.WriteLine($"Imie: {adult.Key}, wiek: {adult.Value}");
            }
        }
    }
}
/* Napisz program, który wczytuje z klawiatury liczbę n, a następnie n imion i wieków
osób.
1) Użyj tablicy, aby przechować wczytane imiona i wiek osób.
2) Użyj listy, aby przechować tylko te imiona, które zaczynają się na literę A lub a.
3) Użyj słownika, aby przechować pary (imie, wiek) dla wszystkich osób, których wiek jest
większy niż 18 lat.
4) Wypisz na ekranie zawartość tablicy, listy i słownika.
*/

