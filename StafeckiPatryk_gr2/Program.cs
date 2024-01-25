namespace StafeckiPatryk_gr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadania z listami: ");
            List<int> lista = UtworzListe(10);
            WypelnijListe(lista);
            WyswietlListe(lista);
            Console.WriteLine();

            Console.WriteLine("Zadania z tablicami: ");
            int[,] tablica = UtworzTablice();
            WypelnijTabliceDwuwymiarowa(tablica);
            ObliczSumePrzekatnej(tablica);
            Console.WriteLine();

            Console.WriteLine("Zadanie ze słownikami");
            Dictionary<string, string> slownik = UtworzSlownik(new List<(string, string)> { ("Polska", "Warszawa"), ("Niemcy", "Berlin"), ("USA", "Waszyngton"), ("Rosja", "Moskwa"), ("Francja", "Paryż")});
            NazwyKrajow(slownik);
        }

        public static List<int> UtworzListe(int dlugosc)
        {
            try
            {
                if (dlugosc <= 0)
                {
                    throw new ArgumentException("Podana długość tablicy jest <=0 ");
                }
                return new List<int>(new int[dlugosc]);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
                return new List<int>();
            }
        }

        public static void WypelnijListe(List<int> lista)
        {
            Random losowa = new Random();
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i] = losowa.Next(1, 101);
            }
        }

        public static void WyswietlListe(List<int> lista)
        {
            Console.WriteLine("Elementy listy wypelnionej liczbami całkowitymi w zakresie <1;100>: " + string.Join(", ", lista));
        }

        public static int[,] UtworzTablice()
        {
            return new int[3, 3];
        }

        public static void WypelnijTabliceDwuwymiarowa(int[,] tablica)
        {
            Random losowa = new Random();
            for(int i = 0;i < tablica.GetLength(0); i++)
            {
                for(int j = 0; j < tablica.GetLength(1); j++)
                {
                    tablica[i, j] = losowa.Next(1, 9);
                }
            }
        }

        public static void ObliczSumePrzekatnej(int[,] tablica)
        {
            int suma = 0;
            for(int i = 0; i < tablica.GetLength(0); i++)
            {
                suma+= tablica[i, i];
            }
            Console.WriteLine("Suma elementów leżących na przekątnej tablicy 3x3, skłądającej się z losowych elementów z zakresy <1;9>: " + suma);
        }

        public static Dictionary<string, string> UtworzSlownik(List<(string kraj, string stolica)> kraje)
        {
            Dictionary<string, string> slownik = new Dictionary<string, string>();
            foreach(var para in kraje)
            {
                if (string.IsNullOrEmpty(para.kraj) || string.IsNullOrEmpty(para.stolica))
                {
                    continue;
                }
                else
                {
                    slownik[para.kraj] = para.stolica;
                }
            }

            return slownik;
        }

        public static void NazwyKrajow(Dictionary<string, string> kraje)
        {
            Console.WriteLine("Wpisz nazwę kraju aby wyświetlić jego stolice lub wpisz \"q\" jeżeli chcesz wyjść");
            if (kraje.Count > 0)
            {
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "q")
                    {
                        break;
                    }
                    if (kraje.ContainsKey(input))
                    {
                        Console.WriteLine("Kraj: " + input + ", stolica: " + kraje[input]);
                    }
                    else
                    {
                        Console.WriteLine("Nie znam takiego kraju");
                    }
                }
            }
            else
            {
                Console.WriteLine("Słownik jest pusty");
            }
        }   
    }
}
