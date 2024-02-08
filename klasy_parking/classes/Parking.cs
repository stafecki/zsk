using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_parking.classes
{
    internal class Parking
    {
        public string Name {  get; set; }
        public Car[] Cars { get; set; }
        public void AddCar(Car car)
        {
            for(int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i] == null)
                {
                    Cars[i] = car;
                    Console.WriteLine($"Dodano samochód na miejscu parkingowym numer: {i+1}");
                    return;
                }
            }
            Console.WriteLine("Nie znaleziono wolnego miejsca parkingowego");
            return;
        }

        public void RemoveCar(int index)
        {
            if (index >= 0 && index < Cars.Length)
            {
                if (Cars[index] != null)
                {
                    Cars[index] = null;
                    Console.WriteLine("Samochód został usunięty z miejsca parkingowego numer "+index);
                }
                else
                {
                    Console.WriteLine("W podanym miejscu parkingowym nie ma samochodu");
                }
            }
            else
            {
                Console.WriteLine("Błędy numer miejsca postojowego na parkingu");
            }
        }

        public void ShowCars()
        {
            Console.WriteLine($"Parking {Name} ma {Cars.Length} miejsc parkingowych");
            for(int i = 0;i < Cars.Length;i++)
            {
                if (Cars[i] != null)
                {
                    Console.WriteLine($"Miejsce {i+1}");
                    Cars[i].ShowInformation();
                }
                else
                {
                    Console.WriteLine($"Miejsce parkingowe nr: {i+1} jest wolne");
                }
            }
        }
        
    }
}
