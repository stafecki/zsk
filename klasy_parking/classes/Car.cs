using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_parking.classes
{
    internal class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public ushort Year { get; private set; }
        public ConsoleColor Color { get; private set; }
        public void ShowInformation()
        {
            Console.WriteLine($"To jest {this.Brand} {this.Model} z {this.Year}, kolor: {this.Color}"); 
        }
    }
}
