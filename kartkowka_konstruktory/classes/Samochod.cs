using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartkowka_konstruktory.classes
{
    enum StatusSamochodu
    {
        Nowy,
        Uzywany,
        Zabytkowy
    }
    internal class Samochod
    {
        #region Pola
        private string Marka {  get; set; }
        private string Model { get; set; }
        private int RokProdukcji { get; set; }
        private double PojemnoscSilnika { get; set; }
        private bool CzyDiesel { get; set; }
        private DateTime DataZakupu { get; set; }
        private StatusSamochodu StatusSamochodu { get; set;}
        private static string DomyslnyKolor {  get; set; }
        private static int DomyslnyPrzebieg { get; set; }
        #endregion

        #region Konstruktory
        //Konstruktor statyczny
        static Samochod()
        {
            DomyslnyKolor = "Biały";
            DomyslnyPrzebieg = 0;
        }
        //Konstruktor domyślny
        public Samochod()
        {
            Marka = "Ford";
            Model = "Focus";
            RokProdukcji = 2020;
            PojemnoscSilnika = 2.0;
            CzyDiesel = false;
            DataZakupu = new DateTime(2020, 1, 1);
            StatusSamochodu = StatusSamochodu.Nowy;
        }
        //Konstruktory parametrzyczne
        public Samochod(string marka, string model, int rokProdukcji)
        {
            Marka = marka;
            Model = model;
            RokProdukcji = rokProdukcji;
        }
        public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika):this(marka, model, rokProdukcji)
        {
            PojemnoscSilnika = pojemnoscSilnika;
        }
        public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika, bool czyDiesel):this(marka, model, rokProdukcji, pojemnoscSilnika)
        {
            CzyDiesel = czyDiesel;
        }
        public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika, bool czyDiesel, DateTime dataZakupu, StatusSamochodu statusSamochodu) : this(marka, model, rokProdukcji, pojemnoscSilnika, czyDiesel)
        {
            DataZakupu = dataZakupu;
            StatusSamochodu = statusSamochodu;
        }
        #endregion

        #region Metody
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Marka: {this.Marka}, Model: {this.Model}, Rok Produkcji: {this.RokProdukcji}, Pojemność Silnika: {this.PojemnoscSilnika}l, Diesel: {this.CzyDiesel}, Data Zakupu: {this.DataZakupu.ToShortDateString()}, Status: {this.StatusSamochodu}");
        }
        public void WiekSamochodu()
        {
            int wiek = DateTime.Now.Year - DataZakupu.Year;
            if (DataZakupu > DateTime.Now.AddYears(-wiek)){
                wiek--;
            }
            Console.WriteLine($"Wiek samochodu: {wiek} lat(a)");
        }
        #endregion
    }
}
