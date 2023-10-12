using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartkowka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad1
            float a, b, c;
            do
            {
                Console.Clear();
                Console.WriteLine("Podaj bok a: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj bok b: ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj bok c: ");
                c = float.Parse(Console.ReadLine());
            } while (a + b <= c || a + c <= b || b + c <= a);
            float p;

            p = (a + b + c) / 2;

            Console.WriteLine($"Pole trójkąta wynosi: {Math.Sqrt(p*(p-a)*(p-b)*(p-c))}");

            //zad2
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("πr²");
            Console.OutputEncoding = System.Text.Encoding.Default;

            //zad3
            Console.WriteLine($"Rozmiar float: {sizeof(float)} bajtów");
            Console.WriteLine($"Zakres float: {float.MinValue} - {float.MaxValue}");
            Console.WriteLine($"Rozmiar double: {sizeof(double)} bajtów");
            Console.WriteLine($"Zakres double: {double.MinValue} - {double.MaxValue}");

            Console.ReadKey();


        }
    }
}
