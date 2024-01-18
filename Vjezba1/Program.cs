using System.Threading.Channels;

namespace Vjezba1
{
    internal class Program
    {
        public class Proizvod
        {
            public string Naziv { get; set; }
            public decimal Cijena { get; set; }
            public int DostupnaKolicina { get; set; }

            public Proizvod(string naziv, decimal cijena, int dostupnakolicina)
            {
                Naziv = naziv;
                Cijena = cijena;
                DostupnaKolicina = dostupnakolicina;
            }
            public void IspisInformacije()
            {
                Console.WriteLine("Informacije: ");
                Console.WriteLine("Naziv: " + Naziv);
                Console.WriteLine("Cijena: " + Cijena);
                Console.WriteLine("Dostupna kolicina: " + DostupnaKolicina);
            }
        }
        public class ElektronickiUredaj
        {
            public string Naziv { get; set; }
            public string Proizvodjac { get; set; }
            public int GodinaProizvodnje { get; set; }

            public ElektronickiUredaj(string naziv, string proizvodjac, int godina)
            {
                Naziv = naziv;
                Proizvodjac = proizvodjac;
                GodinaProizvodnje = godina;
            }
            public void IspisInformacije()
            {
                Console.WriteLine("Informacije: ");
                Console.WriteLine("Naziv: " + Naziv);
                Console.WriteLine("Proizvodjac: " + Proizvodjac);
                Console.WriteLine("Godina proizvodnje: " + GodinaProizvodnje);
            }
        }

        public class PametniTelefon : ElektronickiUredaj
        {
            public string OperativniSustav { get; set; }

            public PametniTelefon(string naziv, string proizvodjac, int godinaproizvodnje, string operativniSustav)
                : base(naziv, proizvodjac, godinaproizvodnje)
            {
                OperativniSustav= operativniSustav;
            }
            public void InstalirajAplikaciju(string nazivAplikacije)
            {
                Console.WriteLine("Aplikacija: " + nazivAplikacije);
            }
        }




            static void Main(string[] args)
            {
            Proizvod proiz1 = new Proizvod("Juha", 3, 627);
            proiz1.IspisInformacije();
            Console.WriteLine('\n');

            PametniTelefon telefon = new PametniTelefon("Tel1", "Google", 2020, "Android");
            telefon.IspisInformacije();
            telefon.InstalirajAplikaciju("YouTube");

            }
    }
}