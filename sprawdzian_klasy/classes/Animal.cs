using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian_klasy.classes
{
    enum Spiecies
    {
        Pies,
        Kot,
        Królik,
        Mysz,
        Ptak
    }

    enum HealthStatus
    {
        Zdrowy,
        Chory,
        Ranny
    }
    internal class Animal
    {
        #region Pola
        public string Name { get; set; }
        public HealthStatus HealthStatus { get; set; }
        public Spiecies Spiecies { get; set; }
        #endregion

        #region Konstruktory
        public Animal()
        {
            HealthStatus = HealthStatus.Zdrowy;
        }

        public Animal(string name, HealthStatus healthStatus)
        {
            Name = name;
            HealthStatus = healthStatus;
        }

        public Animal(string name, HealthStatus healthStatus, Spiecies spieces) : this(name, healthStatus)
        {
            Spiecies = spieces;
        }

        #endregion

        ~Animal()
        {
            Console.WriteLine("Usunięto zwierzę z pamięci");
        }

    }
}
