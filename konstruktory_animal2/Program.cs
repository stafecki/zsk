using System.Formats.Asn1;
using konstruktory_animal2.classess;
namespace konstruktory_animal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region animalObjects
            /*Animal a1 = new Animal("Burek");
            Console.WriteLine(a1.Describe());
            a1.BirthDate = new DateTime(2000, 2, 3);
            a1.ShowAge();*/

            /*Animal a2= new Animal("Mruczek", new DateTime(2020,1,10));
            Console.WriteLine(a2.Describe());
            a2.BirthDate = new DateTime(2020, 2, 3);
            a2.ShowAge();*/

            /*Animal a3 = new Animal("Kotomiler", new DateTime(2020,1,10), true);
            Console.WriteLine(a3.Describe());
            a3.BirthDate = new DateTime(2020, 2, 3);
            a3.ShowAge();*/

            /*Animal a4 = new Animal("Bobek", new DateTime(2020, 1, 10), true, Kind.Ssak);
            Console.WriteLine(a4.Describe());
            a4.BirthDate = new DateTime(2020, 2, 3);
            a4.ShowAge();*/
            #endregion

            List<Animal> animals = new List<Animal>();

            ShowMainMenu(animals);

            Console.ReadKey();
        }

        private static void ShowMainMenu(List<Animal> animals)
        {
            Console.Clear();
            Console.WriteLine("Witaj w programie do zarządzania zwierzętami");
            Console.WriteLine("1. Dodaj zwierze");
            Console.WriteLine("2. Pokaż listę zwierząt");
            Console.WriteLine("3. Pokaz szczegóły zwierzęcia");
            Console.WriteLine("4. Usuń zwierze");
            Console.WriteLine("5. Zakończ program\n");
            Console.Write("Wybierz jedną z opcji: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewAnimal(animals);
                    break;
                case "2":
                    ShowAnimalList(animals);
                    break;
                case "3":
                    ShowAnimalDetails(animals);
                    break;
                case "4":
                    RemoweAnimal(animals);
                    break;
                case "5":
                    Console.WriteLine("Dziękujemy za skorzystanie z programu");
                    return;
                default:
                    Console.WriteLine("Niepoprawna opcja, naciśnij dowolny klawisz aby spróbowac ponownie");
                    Console.ReadKey();
                    ShowMainMenu(animals);
                    break;
            }
        }

        private static void RemoweAnimal(List<Animal> animals)
        {
            Console.Clear();

            if (animals.Count == 0)
            {
                Console.WriteLine("Nie ma żadnych zwierząt w liście");
            }
            else
            {
                Console.WriteLine("1. Usun wszystkie zwierzęta");
                Console.WriteLine("2. Usuń jedno zwierzę");

                Console.WriteLine("\n Wybierz jedną z opcji: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        animals.Clear();
                        if(animals.Count == 0)
                        {
                            Console.WriteLine("Usunięto wszystkie zwierzęta");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Lista zwierząt: ");
                        for (int i = 0; i < animals.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ". " + animals[i].Name);
                        }
                        Console.WriteLine("Podaj numer zwierzęcia, które chcesz usunąć: ");
                        int index = int.Parse(Console.ReadLine())-1;
                        if(index >= 0 && index < animals.Count)
                        {
                            animals.RemoveAt(index);
                            Console.WriteLine("Usunięto zwierze pod numerem " + (index+1));
                        }
                        else
                        {
                            Console.WriteLine("Niepoprawny numer spróbuj ponownie");
                        }
                        break;
                    default:
                        Console.WriteLine("Niepoprawna opcja, spróbuj ponownie");
                        break;
                }
            }
            Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do meny głównego\n");
            Console.ReadKey();
            ShowMainMenu(animals);
        }

        private static void ShowAnimalDetails(List<Animal> animals)
        {
            Console.Clear();

            if (animals.Count == 0)
            {
                Console.WriteLine("Nie ma żadnych zwierząt w liście");
            }
            else
            {
                Console.WriteLine("Lista zwierząt: ");
                for (int i = 0; i < animals.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + animals[i].Name);
                }
                Console.WriteLine("Podaj numer zwierzęcia, którego szczegóły chcesz zobaczyć: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                if (index >= 0 && index<animals.Count)
                {
                    Animal animal = animals[index];
                    Console.WriteLine("\nSzczegóły zwierzęcia: ");
                    Console.WriteLine(animal.Describe());
                    animal.ShowAge();
                }
                else
                {
                    Console.WriteLine("Niepoprawny numer. Spróbuj ponownie");
                }
            }
            Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do meny głównego\n");
            Console.ReadKey();
            ShowMainMenu(animals);
        }

        private static void ShowAnimalList(List<Animal> animals)
        {
            Console.Clear();

            if (animals.Count == 0)
            {
                Console.WriteLine("Nie ma żadnych zwierząt w liście");
            }
            else
            {
                Console.WriteLine("Lista zwierząt: ");
                for (int i = 0; i < animals.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + animals[i].Name);
                }
            }
            Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do meny głównego\n");
            Console.ReadKey();
            ShowMainMenu(animals);
        }

        private static void AddNewAnimal(List<Animal> animals)
        {
            Console.Clear();
            Console.Write("Podaj nazwę zwierzęcia: ");
            string name = Console.ReadLine();
            Console.Write("Podaj datę urodzenia zwierzęcia (w formacie RRR-MM-DD): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Czy zwierze jest ssakiem? (tak/nie): ");
            bool isMammal = Console.ReadLine().ToLower() == "tak";
            Console.Write("Podaj rodzaj zwierzęcia (Ptak, Ryba, Gad, Płaz, Ssak): ");
            Kind kind = (Kind)Enum.Parse(typeof(Kind), Console.ReadLine());

            Animal animal = new Animal(name, birthDate, isMammal, kind);

            animals.Add(animal);

            Console.WriteLine("\nDodano nowe zwierzę: " + animal.Name);
            Console.WriteLine("\nWciśnij dowolny klawisz, aby wrócić do meny głównego\n");
            Console.ReadKey();
            ShowMainMenu(animals);
        }
    }
}