using destruktory_symulator.classes;
namespace destruktory_symulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Dictionary<int, Car> carDictionary = new Dictionary<int, Car>();

            while (true)
            {
                Console.WriteLine("\nMenu symulatora jazdy samochodem");
                Console.WriteLine("1. Dodaj samochód");
                Console.WriteLine("2. Wyświetl listę samochodów");
                Console.WriteLine("3. Jedź samochodem");
                Console.WriteLine("4. Symuluj losowe uszkodzenie");
                Console.WriteLine("5. Zezłomuj samochód");
                Console.WriteLine("6. Wyjście");
                Console.Write("Podaj wybór: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\nPodaj markę samochodu:");
                        string brand = Console.ReadLine();
                        Console.Write("Podaj model samochodu:");
                        string model = Console.ReadLine();
                        Car newCar = new Car(brand, model);
                        cars.Add(newCar);
                        carDictionary[cars.Count] = newCar;
                        Console.WriteLine("Dodano nowy samochód");
                        break;
                    case 2:
                        Console.WriteLine("\nLista samochodów:");
                        foreach (Car car in cars)
                        {
                            Console.WriteLine($"{car.Brand} {car.Model}");
                        }
                        break;
                    case 3:
                        Console.Write("\nPodaj numer samochodu do jazdy:");
                        int carNumber = int.Parse(Console.ReadLine());
                        if (carDictionary.TryGetValue(carNumber, out Car selectedCar))
                        {
                            selectedCar.Drive();
                        }
                        else
                        {
                            Console.WriteLine("Nierawidłowy numer samochodu");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nPodaj numer samochodu do symulacji uszkodzenia: ");
                        int damagedCarNumber = int.Parse(Console.ReadLine());
                        if(carDictionary.TryGetValue(damagedCarNumber, out Car damagedCar))
                        {
                            damagedCar.SimulateRandomDamage();
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowy numer samochodu");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nPodaj numer samochodu do zezłomowania: ");
                        int scrappedCarNumber = int.Parse(Console.ReadLine());
                        if (carDictionary.TryGetValue(scrappedCarNumber, out Car scrappedCar))
                        {
                            scrappedCar = null;
                            GC.Collect();
                            Console.WriteLine($"Samochód {scrappedCarNumber} został zezłomowany");
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowy numer samochodu");
                        }
                        break;
                    case 6:
                        Console.WriteLine("\nZamykanie symulatora");
                        return;
                    default:
                        break;
                }


            }

            Console.ReadKey();
        }
        static public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("\nMenu symulatora jazdy samochodem");
            Console.WriteLine("1. Dodaj samochód");
            Console.WriteLine("2. Wyświetl listę samochodów");
            Console.WriteLine("3. Jedź samochodem");
            Console.WriteLine("4. Symuluj losowe uszkodzenie");
            Console.WriteLine("5. Zezłomuj samochód");
            Console.WriteLine("6. Wyjście");
            int choice = GetUserInput();
            switch(choice)
            {
                case 1:
                    break;
                case 1:
                    break;
                case 1:
                    break;
                case 1:
                    break;
                case 1:
                    break;
                case 1:
                    break;
                default:
                    Console.WriteLine("Niepoprawna opcja, naciśnij dowolny klawisz aby wrócić do menu glownego");
                    Console.ReadKey();
                    DisplayMenu();
            }
        }

        static public int GetUserInput()
        {
            Console.Write("Wybierz opcję: ");
            int input;
            while (true)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd: Podaj liczbę całkowitą");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Błąd: " + e.Message);
                }
            }
            return input;
        }

        static public void AddCar(List<Car> cars, Dictionary<int, Car> carDict)
        {
            Console.Clear();
            Console.Write("\nPodaj markę samochodu:");
            string brand = Console.ReadLine();
            Console.Write("Podaj model samochodu:");
            string model = Console.ReadLine();
            Car newCar = new Car(brand, model);
            cars.Add(newCar);
            carDict[cars.Count] = newCar;
            Console.WriteLine("Dodano nowy samochód");
            Console.WriteLine("Naciśnij dowolny klawisz aby powrócić do menu glownego");
            Console.ReadKey();
            DisplayMenu();
        }
        W
        static public void DisplayCars(Dictionary<int, Car> carDict)
        {
            if (carDict.Count == 0)
            {
                Console.WriteLine("W liście nie ma żadnego samochodu");
            }
            else
            {
                Console.WriteLine("Lista pojazdów: ");
                foreach (var car in carDict)
                {
                    Console.WriteLine($"{car.Key}. {car.Value.Brand} {car.Value.Model}");
                }
            }
            Console.WriteLine("Naciśnij dowolny klawisz aby powrócić do menu glownego");
            Console.ReadKey();
            DisplayMenu();
        }
    }
}
