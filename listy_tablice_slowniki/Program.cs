using System;
using System.Linq;

namespace listy_tablice_slowniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = ReadInt("Podaj liczbę n: ", 0, int.MaxValue);
            string[] names = new string[n];
            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = ReadString($"Podaj imie osoby {i + 1}: ");
                ages[i] = ReadInt($"Podaj wiek osoby {i + 1}: ", 0, 120);
            }

            List<string> namesThatStartsWithA = names.Where(name => name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

            Dictionary<string, int> adults = names.Zip(ages, (name, age) => new { name, age })
                .Where(person => person.age >= 18)
                .ToDictionary(person => person.name, person => person.age);

            Console.WriteLine("Tablica imion i wiekow tych osob: ");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine($"{names[i]} - {ages[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("Lista osob z imieniem zaczynającym sie na \"a\" ");
            for(int i = 0; i < namesThatStartsWithA.Count; i++)
            {
                Console.WriteLine(namesThatStartsWithA[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Lista osob dorosłych");
            foreach(var adult in adults)
            {
                Console.WriteLine($"Imie: {adult.Key}, wiek: {adult.Value}");
            }



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
            bool valid;
            do
            {
                Console.Write(prompt);
                result = Console.ReadLine();
                valid = !(string.IsNullOrWhiteSpace(result));
                if (!valid)
                {
                    Console.WriteLine("Nie podawaj pustej wartości");
                }
            } while (!valid);
            return result;
        }
    }
}
