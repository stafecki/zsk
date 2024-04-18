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
                DisplayMenu(cars, carDictionary);
            }
        }
        static public void DisplayMenu(List<Car> cars, Dictionary<int, Car> carDict)
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
            switch (choice)
            {
                case 1:
                    AddCar(cars, carDict);
                    break;
                case 2:
                    DisplayCars(carDict);
                    break;
                case 3:
                    DriveCar(carDict);
                    break;
                case 4:
                    SimulateDamage(carDict);
                    break;
                case 5:
                    ScrapCar(carDict);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Niepoprawna opcja, naciśnij dowolny klawisz aby wrócić do menu glownego");
                    Console.ReadKey();
                    DisplayMenu(cars, carDict);
                    break;
            }
        }

        static public int GetUserInput(Dictionary<int, Car> carDict = null)
        {
            
            int input;
            while (true)
            {
                Console.Write("\nPodaj wartość(int): ");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (carDict == null || carDict.ContainsKey(input))
                    {
                        return input;
                    }
                    else
                    {
                        Console.WriteLine("Numer samochodu nie istnieje w słowniku");
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy format danych, spróbuj ponownie");
                }
            }
            return input;
        }

        static public void AddCar(List<Car> cars, Dictionary<int, Car> carDict)
        {
            Console.Clear();
            Console.Write("Podaj markę samochodu:");
            string brand = Console.ReadLine();
            Console.Write("Podaj model samochodu:");
            string model = Console.ReadLine();
            Car newCar = new Car(brand, model);
            cars.Add(newCar);
            carDict[cars.Count] = newCar;
            Console.WriteLine("Dodano nowy samochód");
            Console.WriteLine("Naciśnij dowolny klawisz aby powrócić do menu glownego");
            Console.ReadKey();
        }
        
        static public void DisplayCars(Dictionary<int, Car> carDict)
        {
            Console.Clear();
            if (carDict.Count == 0)
            {
                Console.WriteLine("Brak samochodu do wyświetlenia");
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
        }

        static public void DriveCar(Dictionary<int, Car> carDict)
        {
            Console.Clear();
            int carNumber = GetUserInput(carDict);
            Car carToDrive = carDict[carNumber];
            carToDrive.Drive();
            Console.WriteLine("Naciśnij dowolny klawisz aby powrócić do menu glownego");
            Console.ReadKey();
        }

        static public void SimulateDamage(Dictionary<int, Car> carDict)
        {
            Console.Clear();
            int carNumber = GetUserInput(carDict);
            Car carToDamage = carDict[carNumber];
            carToDamage.SimulateRandomDamage();
            Console.WriteLine("Naciśnij dowolny klawisz aby powrócić do menu glownego");
            Console.ReadKey();
        }

        static public void ScrapCar(Dictionary<int, Car> carDict)
        {
            Console.Clear();
            int carNumber = GetUserInput(carDict);
            Car carToDestroy = carDict[carNumber];
            carToDestroy = null;
            GC.Collect();
            Console.WriteLine($"Samochód {carNumber} został zezłomowany");
            Console.WriteLine("Naciśnij dowolny klawisz aby powrócić do menu glownego");
            Console.ReadKey();
        }


    }
}