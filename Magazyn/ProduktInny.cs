using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    class ProduktInny
    {
        [Serializable]
        public class Napój : Produkt
        {
            private const string dział = "Napoje";
            private double pojemnośćButelki;
            public Napój() { }
            public Napój(string nazwa, decimal cena, int ilość, double pojemnośćButelki, DateTime dataProdukcji, DateTime dataWażności)
                : base(nazwa, cena, ilość, dataProdukcji, dataWażności)
            {
                this.pojemnośćButelki = pojemnośćButelki;
            }
            public override string ToString()
            {
                return base.ToString() + "\r\n\t\tPojemność: " + pojemnośćButelki + " l\r\n\t\tDział: " + dział;
            }
        }

        [Serializable]
        public class Przyprawa : Produkt
        {
            private const string dział = "Przyprawy";
            public Przyprawa() { }
            public Przyprawa(string nazwa, decimal cena, int ilość, DateTime dataProdukcji, DateTime dataWażności)
                : base(nazwa, cena, ilość, dataProdukcji, dataWażności) { }
            public override string ToString()
            {
                return base.ToString() + "\r\n\t\tDział: " + dział;
            }
        }

        [Serializable]
        public class Słodycze : Produkt
        {
            private const string dział = "Słodycze";
            public Słodycze() { }
            public Słodycze(string nazwa, decimal cena, int ilość, DateTime dataProdukcji, DateTime dataWażności)
                : base(nazwa, cena, ilość, dataProdukcji, dataWażności) { }
            public override string ToString()
            {
                return base.ToString() + "\r\n\t\tDział: " + dział;
            }
        }
    }
}
