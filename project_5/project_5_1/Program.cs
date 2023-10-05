namespace project_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MinValue); //-2147483648
            Console.WriteLine(int.MaxValue); //2147483647

            Console.WriteLine(char.MaxValue); //?

            string firstName = "Janusz";
            Console.WriteLine(firstName.Length); //6

            Console.WriteLine(firstName[0]); //J

            string lastName = "Nowak";
            Console.WriteLine(firstName.Equals(lastName)); //False
            Console.WriteLine("Janusz".Equals("Janusz")); //True
            Console.WriteLine("Janusz".Equals("janusz")); //False

            //-----While---------------------------------------------------------------------------------------------------

            Console.Write("Podaj imię ");
            string? name = Console.ReadLine();
            //Console.WriteLine($"Imię: {name}");

            while (name == "") {
                Console.Clear();
                Console.Write("Podaj imię ");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Imię: {name}");

            //-----DoWhile----------------------------------------------------------------------------------------------------
            
            float a;
            do
            {
                Console.Clear();
                Console.WriteLine("Podaj bok a: ");
                a = float.Parse(Console.ReadLine());
            } while (a <= 0);

            Console.WriteLine($"Pole kwadratu o boku {a} wynosi {a*a:F2}");

            //Pole trójkąta obliczone wzorem Herona
            float x, y , z;
            do
            {
                Console.Clear();
                Console.WriteLine("Podaj x: ");
                x = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj y: ");
                y = float.Parse(Console.ReadLine());
                Console.WriteLine("Podaj z: ");
                z = float.Parse(Console.ReadLine());
            } while (x+y<z || x+z<y || z+y<x);
            float p = (x + y + z) / 2
            Console.WriteLine($"Pole równa się {Math.Sqrt(p*(p-x)*(p-y)*(p-z))}");

        }
    }
}