using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    [Serializable]
    abstract class Produkt : IProdukt, IComparable
    {
        public Produkt() { }
        public Produkt(string nazwa, decimal cena, int ilość, DateTime dataProdukcji, DateTime dataWażności)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.ilość = ilość;
            this.dataProdukcji = dataProdukcji;
            this.dataWażności = dataWażności;
        } // koniec konstruktora

        protected string nazwa;
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        protected int ilość;
        public int Ilość
        {
            get { return ilość; }
            set { ilość = value; }
        }

        protected decimal cena;
        public decimal Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        protected DateTime dataProdukcji;
        public DateTime DataProdukcji
        {
            get { return dataProdukcji; }
            set { dataProdukcji = value; }
        }
        protected DateTime dataWażności;
        public DateTime DataWażności
        {
            get { return dataWażności; }
            set { dataWażności = value; }
        }
        public override string ToString()
        {
            return "\r\n   " + Nazwa + "\r\n\t\tCena: " + decimal.Round(Cena, 2) + " zł\r\n\t\tIlość: " + Ilość +
                "\r\n\t\tData produkcji: " + DataProdukcji.ToShortDateString() +
                "\r\n\t\tData ważności: " + DataWażności.ToShortDateString();
        }
        public int CompareTo(object obj)
        {
            return this.Nazwa.CompareTo(((Produkt)obj).Nazwa);
        }
    }
}
