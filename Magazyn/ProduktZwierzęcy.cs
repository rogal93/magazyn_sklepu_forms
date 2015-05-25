using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    class ProduktZwierzęcy
    {
        [Serializable]
        public class Mięso : Produkt
        {
            private const string dział = "Mięso";
            public Mięso() { }
            public Mięso(string nazwa, decimal cena, int ilość, DateTime dataProdukcji, DateTime dataWażności)
                : base(nazwa, cena, ilość, dataProdukcji, dataWażności) { }
            public override string ToString()
            {
                return "\r\n   " + Nazwa + "\r\n\t\tCena: " + decimal.Round(Cena, 2) + " zł\r\n\t\tIlość: " + Ilość +
                " kg\r\n\t\tData produkcji: " + DataProdukcji.ToShortDateString() +
                "\r\n\t\tData ważności: " + DataWażności.ToShortDateString() + "\r\n\t\tDział: " + dział;
            }
        }

        [Serializable]
        public class Nabiał : Produkt
        {
            private const string dział = "Nabiał";
            public Nabiał() { }
            public Nabiał(string nazwa, decimal cena, int ilość, DateTime dataProdukcji, DateTime dataWażności)
                : base(nazwa, cena, ilość, dataProdukcji, dataWażności) { }
            public override string ToString()
            {
                return base.ToString() + "\r\n\t\tDział: " + dział;
            }
        }
    }
}
