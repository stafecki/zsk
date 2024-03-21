using kartkowka_konstruktory.classes;
namespace kartkowka_konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Samochod> samochody = new List<Samochod>();
            Samochod s1 = new Samochod();
            Samochod s2 = new Samochod("Toyota", "Corolla", 2015, 2, false, new DateTime(2019,4,2), StatusSamochodu.Uzywany);
            samochody.AddRange(new[] { s1, s2 });
            LiczbaPojazdow(samochody);
            foreach(Samochod samochod in samochody)
            {
                samochod.WyswietlInformacje();
                samochod.WiekSamochodu();
            }
        }
        static public void LiczbaPojazdow(List<Samochod> samochody)
        {
            Console.WriteLine("Liczba utworzonych samochodów: " + samochody.Count);
        }

    }
}
