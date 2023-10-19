namespace project_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Podaj bok a: ");
            double a;
            a=double.Parse(Console.ReadLine());
            */

            /*
            Console.Write("Podaj bok a: ");
            double a;
            double.TryParse(Console.ReadLine(), out a);
            */

            /*
            Console.Write("Podaj bok a: ");
            double a;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine(a);
            }
            */
            /*bool x = true;

            while (x == true)
            {
                double a;
                Console.Write("Podaj bok a: ");
                while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.Write("Podaj poprawnie bok a: ");
                }
                //Console.WriteLine($"Bok równa się {a} okok");

                double b;
                Console.Write("Podaj bok b: ");
                while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.Write("Podaj poprawnie bok b: ");
                }

                double c;
                Console.Write("Podaj bok c: ");
                while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.Write("Podaj poprawnie bok c: ");
                }

                //Console.WriteLine(IsTriangle(a,b,c));

                if (IsTriangle(a, b, c))
                {
                    double p;
                    p = (a + b + c) / 2;
                    p = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine($"Pole trójkąta wynosi {p}");
                    x = false;
                }
                else
                {

                    x = true;   
                }
            }*/
            bool IsCorrect = false;
            do
            {
                double a;
                Console.Write("Podaj bok a: ");
                while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.Write("Podaj poprawnie bok a: ");
                }
                //Console.WriteLine($"Bok równa się {a} okok");

                double b;
                Console.Write("Podaj bok b: ");
                while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.Write("Podaj poprawnie bok b: ");
                }

                double c;
                Console.Write("Podaj bok c: ");
                while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.Write("Podaj poprawnie bok c: ");
                }

                //Console.WriteLine(IsTriangle(a,b,c));

                if (IsTriangle(a, b, c))
                {
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.WriteLine($"Pole trójkąta o bokach {a}, {b} oraz {c} wynosi: {TriangleArea(a,b,c):F4} cm²");
                    Console.OutputEncoding = System.Text.Encoding.Default;
                    IsCorrect = true;
                }
                else
                {
                    Console.WriteLine("Z podanych boków nie można zbudować trójkąta");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            } while (!IsCorrect);
            

        }

        
        static bool IsTriangle(double a, double b, double c)
        {
            if(a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
            
        }

        static double TriangleArea(double a, double b, double c)
        {
            double p;
            p = (a + b + c) / 2;
            p = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return p;
        }
    }
}