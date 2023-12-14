namespace slowniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Anna");
            d.Add(2, "Jacapraca");
            d.Add(3, "kotomilerwampir");

            foreach(var item in d)
            {
                Console.WriteLine($"{item.Value} ");
            }
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------------------------------------

            Dictionary<string, int> d1 = new Dictionary<string, int>();
            d1.Add("jeden", 1);
            d1.Add("dwa", 2);
            d1.Add("trzy", 3);

            foreach(var item in d1)
            {
                Console.WriteLine("{1}: {0}", item.Value, item.Key);
            }
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------------------------------------

            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("Polska", "Warszawa");
            capitals.Add("Niemcy", "Berlin");
            capitals.Add("Francja", "Paryż");

            foreach(KeyValuePair<string,  string> item in capitals)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            Console.WriteLine( );

            //-----------------------------------------------------------------------------------------------------------------------------

            Dictionary<string, string> phones = new Dictionary<string, string>()
            {
                { "+48 123 456 789", "Kandzie"},
                { "+48 123 456 788", "jacapraca"},
                { "+48 123 456 787", "kotomilerwampir"}
            };

            foreach(var item in phones)
            {
                Console.WriteLine($"{item.Value}: {item.Key}");
            }
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------------------------------------

            Dictionary<string, string> colors = new Dictionary<string, string>()
            {
                {"Biały", "#FFFFFF" },
                {"Czarny", "#000000" },
                {"Czerwony", "#FF0000"},
                {"Zielony", "#00FF00"},
                {"Niebieski", "#0000FF"},
            };

            foreach(var item in colors)
            {
                Console.WriteLine($"Kolor: {item.Key}, hex: {item.Value}");
            }
            Console.WriteLine();

            //-----------------------------------------------------------------------------------------------------------------------------*/


            /*
                Napisz program, który tworzy słownik typu Dictionary<string, string> i umożliwia użytkownikowi 
                wprowadzenie dowolnej liczby par klucz-wartość.
                Następnie program wyświetla wszystkie elementy słownika w formacie: “Klucz: …, wartość: …”.
                Użyj pętli for do pobierania danych od użytkownika i pętli foreach do wyświetlania elementów słownika.
            */
            Dictionary<string, string> slownik = new Dictionary<string, string>();
            Console.Write("Podaj ile par klucz-wartosc chcesz wprowadzic: ");
            int size = int.Parse(Console.ReadLine());
            for(int i = 0; i < size; i++)
            {
                Console.Write($"Podaj klucz {i+1}: ");
                string? key = Console.ReadLine();
                Console.Write($"Podaj wartosc {i+1}: ");
                string? value = Console.ReadLine();

                slownik.Add(key, value);
            }
            Console.WriteLine();

            foreach(var item in slownik)
            {
                Console.WriteLine($"Klucz: {item.Key}, wartosc: {item.Value}");
            };
            Console.WriteLine();


        }
    }
}
