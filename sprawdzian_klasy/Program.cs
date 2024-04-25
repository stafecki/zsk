using sprawdzian_klasy.classes;
namespace sprawdzian_klasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Dictionary<int, Animal> animalDict = new Dictionary<int, Animal>();
            Animal test1 = new Animal();
            Animal test2 = new Animal("asd", HealthStatus.Ranny);
            Animal test3 = new Animal("asd", HealthStatus.Zdrowy, Spiecies.Pies);
            test1 = null;
            GC.Collect();
            DisplayMenu(animals, animalDict);
        }

        public static void DisplayMenu(List<Animal> animals, Dictionary<int, Animal> animalDict)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("1. Dodaj zwierzę");
                Console.WriteLine("2. Wyświetl zwierzęta");
                Console.WriteLine("3. Leczenie zwierzęcia");
                Console.WriteLine("4. Symulacja zachorowania");
                Console.WriteLine("5. Adopcja zwierzęcia");
                Console.WriteLine("6. Wyjście z programu");
                Console.Write("Podaj wybór: ");
                int choice = GetUserInput(animalDict);
                switch (choice)
                {
                    case 1:
                        AddAnimal(animals, animalDict);
                        break;
                    case 2:
                        DisplayAnimals(animalDict);
                        break;
                    case 3:
                        HealAnimal(animalDict);
                        break;
                    case 4:
                        GetSick(animalDict);
                        break;
                    case 5:
                        AdoptAnimal(animalDict);
                        break;
                    case 6:
                        Console.WriteLine("Dziekuje za skorzystanie z programu");
                        Console.WriteLine("Naciśnij dowolny przycisk by wyjść");
                        Console.ReadKey();
                        return;
                }
            }
            
        }

        public static void AdoptAnimal(Dictionary<int, Animal> animalDict)
        {
            Console.Clear();
            if (animalDict.Count > 0)
            {
                Console.WriteLine("Wybierz zwierze do adopcji");
                int choice = GetUserInput(animalDict);
                animalDict[choice] = null;
                GC.Collect();
                Console.WriteLine("Pomyślnie zaadoptowano zwierze");
            }
            else
            {
                Console.WriteLine("Nie ma zwierząt w liście");
            }
            
            Console.ReadKey();
        }

        public static void GetSick(Dictionary<int, Animal> animalDict)
        {
            Console.Clear();
            if(animalDict.Count > 0)
            {
                Console.WriteLine("Wybierz zwierze, u którego chcesz wywołać chorobę: ");
                int choice = GetUserInput(animalDict);
                animalDict[choice].HealthStatus = HealthStatus.Chory;
                Console.WriteLine("Pomyślnie dodano chorobę");
            }
            else
            {
                Console.WriteLine("Nie ma zwierząt w liście");
            }

            Console.ReadKey();
        }

        public static void HealAnimal(Dictionary<int, Animal> animalDict)
        {
            Console.Clear();
            if(animalDict.Count > 0)
            {
                Console.WriteLine("Wybierz zwierze, które chcesz uleczyć");
                int choice = GetUserInput(animalDict);
                if (animalDict[choice].HealthStatus == HealthStatus.Zdrowy)
                {
                    Console.WriteLine("Wybrane zwierze jest zdrowe");
                }
                else
                {
                    animalDict[choice].HealthStatus = HealthStatus.Zdrowy;
                    Console.WriteLine("Pomyslnie uleczono zwierze");
                }
            }
            else
            {
                Console.WriteLine("Nie ma zwierząt w liście");
            }
            
            Console.ReadKey();
        }

        private static void DisplayAnimals(Dictionary<int, Animal> animalDict)
        {
            Console.Clear();
            if(animalDict.Count>0)
            {
                Console.WriteLine("Lista zwierząt: ");
                foreach (var animal in animalDict)
                {
                    Console.WriteLine($"{animal.Key}: {animal.Value.Name}, stan zdrowia: {animal.Value.HealthStatus}");
                }
                
            }
            else
            {
                Console.WriteLine("Nie ma zwierząt w liście");
            }
            Console.ReadKey();
        }

        public static void AddAnimal(List<Animal> animals, Dictionary<int, Animal> animalDict)
        {
            Console.Clear();
            Console.WriteLine("Podaj imie zwierzęcia");
            string name = Console.ReadLine();
            HealthStatus healthStatus = HealthStatus.Zdrowy;
            Animal newAnimal = new Animal(name, healthStatus);
            animals.Add(newAnimal);
            animalDict[animals.Count] = newAnimal;
            Console.WriteLine("Dodano zwierze");
            Console.ReadKey();
        }

        public static int GetUserInput(Dictionary<int, Animal> animalDict)
        {
            int input;
            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (animalDict == null || animalDict.ContainsKey(input))
                    {
                        return input;
                    }
                    else
                    {
                        Console.WriteLine("Nie ma takiego zwierzęcia w liście");
                    }
                    return input;
                }
                else
                {
                    Console.WriteLine("Zły format");
                }
            } 
        }
    }
}
