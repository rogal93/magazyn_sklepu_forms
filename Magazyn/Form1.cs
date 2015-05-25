using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class Form1 : Form
    {
        static string pasek = "--------------------------------------------------------------------";
        static string pasekListyProduktów = "-----------------------Lista produktów----------------------";
        static FileStream fs = null;
        static BinaryFormatter formater = new BinaryFormatter();

        List<Produkt> magazyn = new List<Produkt> { };

        string nazwa = string.Empty;
        decimal cena = 0M;
        int ilość = 1;
        DateTime dataProdukcji = new DateTime();
        DateTime dataWażności = new DateTime();
        double pojemnośćButelki = 0;

        public Form1()
        {
            Deserialize();
            InitializeComponent();
        }
        
        private void Dodaj()                         // METODA DODAJĄCA PRODUKT              
        {
            nazwa = nazwaTextBox.Text;
            cena = cenaNumeric.Value;
            dataProdukcji = dataProdukcjiPicker.Value;
            dataWażności = dataWażnościPicker.Value;
            ilość = (int)ilośćNumeric.Value;

            pojemnośćButelki = (double)pojemnośćNumeric.Value;
            
            switch (DziałBox.Text)
            {
                case "Nabiał": magazyn.Add(new ProduktZwierzęcy.Nabiał(nazwa, cena, ilość, dataProdukcji, dataWażności)); break;
                case "Mięso": magazyn.Add(new ProduktZwierzęcy.Mięso(nazwa, cena, ilość, dataProdukcji, dataWażności)); break;
                case "Słodycze": magazyn.Add(new ProduktInny.Słodycze(nazwa, cena, ilość, dataProdukcji, dataWażności)); break;
                case "Produkty zbożowe": magazyn.Add(new ProduktRoślinny.Zbożowy(nazwa, cena, ilość, dataProdukcji, dataWażności)); break;
                case "Napoje": magazyn.Add(new ProduktInny.Napój(nazwa, cena, ilość, pojemnośćButelki, dataProdukcji, dataWażności)); break;
                case "Owoce": magazyn.Add(new ProduktRoślinny.Owoc(nazwa, cena, ilość, dataProdukcji, dataWażności)); break;
                case "Warzywa": magazyn.Add(new ProduktRoślinny.Warzywo(nazwa, cena, ilość, dataProdukcji, dataWażności)); break;
                case "Przyprawy": magazyn.Add(new ProduktInny.Przyprawa(nazwa, cena, ilość, dataProdukcji, dataWażności)); break;
                case "": MessageBox.Show("Nie wybrano działu, do którego ma należeć produkt", "Błąd!"); break;
                default: break;
            }

            if (DziałBox.Text != "")
            {
                magazyn.Sort();
                Serialize();
                MessageBox.Show("Pomyślnie dodano nowy produkt: " + nazwa + ".", "Dodawanie produktu");
            }
            textBox.Text = string.Empty;
            Serialize();
        } // koniec metody

        private void Wypisz()                        // METODA WYPISUJĄCA LISTĘ PRODUKTÓW    
        {
            int licznik = 0;
            bool zaznaczenie = false;
            textBox.Text = string.Empty;
            

            for (int i = 0; i < 8; i++)
            {
                if (listaDziałów.GetItemChecked(i))
                {
                    zaznaczenie = true;
                    break;
                }
            }

            if (zaznaczenie)
            {
                textBox.Text += pasek + "\r\n" + pasekListyProduktów + "\r\n" + pasek;
                foreach (var produkt in magazyn)
                {
                    if (listaDziałów.GetItemChecked(0))
                        if (produkt is ProduktZwierzęcy.Nabiał)
                        {
                            textBox.Text += produkt + "\r\n" + pasek;
                            licznik++;
                        }
                    if (listaDziałów.GetItemChecked(1))
                        if (produkt is ProduktZwierzęcy.Mięso)
                        {
                            textBox.Text += produkt + "\r\n" + pasek;
                            licznik++;
                        }
                    if (listaDziałów.GetItemChecked(2))
                        if (produkt is ProduktInny.Słodycze)
                        {
                            textBox.Text += produkt + "\r\n" + pasek;
                            licznik++;
                        }
                    if (listaDziałów.GetItemChecked(3))
                        if (produkt is ProduktRoślinny.Zbożowy)
                        {
                            textBox.Text += produkt + "\r\n" + pasek;
                            licznik++;
                        }
                    if (listaDziałów.GetItemChecked(4))
                        if (produkt is ProduktInny.Napój)
                        {
                            textBox.Text += produkt + "\r\n" + pasek;
                            licznik++;
                        }
                    if (listaDziałów.GetItemChecked(5))
                        if (produkt is ProduktRoślinny.Owoc)
                        {
                            textBox.Text += produkt + "\r\n" + pasek;
                            licznik++;
                        }
                    if (listaDziałów.GetItemChecked(6))
                        if (produkt is ProduktRoślinny.Warzywo)
                        {
                            textBox.Text += produkt + "\r\n" + pasek;
                            licznik++;
                        }
                    if (listaDziałów.GetItemChecked(7))
                        if (produkt is ProduktInny.Przyprawa)
                        {
                            textBox.Text += produkt + "\r\n" + pasek;
                            licznik++;
                        }
                }
                textBox.Text += "\r\n   Liczba produktów: " + licznik;
            } // koniec instrukcji if
            else
                MessageBox.Show("Zaznacz działy do wyświetlenia!", "Wyświetlanie");
        } // koniec metody

        private int WyszukajPoNazwie(string nazwa)   // METODA WYSZUKUJĄCA PRODUKT PO NAZWIE 
        {
            textBox.Text = string.Empty;
            bool znaleziono = false;
            foreach (var produkt in magazyn)
                if (produkt.Nazwa == nazwa)
                {
                    znaleziono = true;
                    if (nazwaWyszukajTextBox.Text != string.Empty)
                    {
                        textBox.Text += "\r\n\tWyszukano produkt:\r\n" + pasek + produkt + "\r\n" + pasek;
                        MessageBox.Show("\tWyszukano produkt:\r\n   " + produkt.ToString(), "Wyszukiwanie po nazwie");
                    }
                    return magazyn.IndexOf(produkt);
                }
            if (!znaleziono)
                MessageBox.Show("Nie ma produktu o podanej nazwie w naszych magazynie!", "Wyszukiwanie po nazwie");
            return -1;
        } // koniec metody

        private void WyszukajPoCenie()               // METODA WYSZUKUJĄCA PRODUKT PO CENIE  
        {
            textBox.Text = string.Empty;
            bool znaleziono = false;
            foreach (var produkt in magazyn)
                if ((produkt.Cena <= przedziałNumeric1.Value && produkt.Cena >= przedziałNumeric2.Value) ||
                    (produkt.Cena <= przedziałNumeric2.Value && produkt.Cena >= przedziałNumeric1.Value))
                {
                    znaleziono = true;
                    textBox.Text += pasek + produkt + "\r\n" + pasek;
                }
            if (!znaleziono)
                MessageBox.Show("Nie ma produktu za daną cenę w naszych magazynie!", "Wyszukiwanie po cenie");
            else
            {
                textBox.Text = "\r\n\tWyszukano:\r\n" + textBox.Text;
                MessageBox.Show("Wyszukano produkty o danej cenie.", "Wyszukiwanie po cenie");
            }
        } // koniec metody

        private void UsuńProdukt()                   // METODA, KTÓRA USUWA PRODUKT          
        {
            textBox.Text = string.Empty;
            int indeks = WyszukajPoNazwie(nazwaUsuńTextBox.Text);
            if (indeks >= 0)
            {
                magazyn.RemoveAt(indeks);
                MessageBox.Show("Usunięto produkt o nazwie " + nazwaUsuńTextBox.Text + ".", "Usuwanie");
            }
            nazwaUsuńTextBox.Text = string.Empty;
            Serialize();
        } // koniec metody

        private void Deserialize()                   // METODA, KTÓRA ODCZYTUJE DANE Z PLIKU 
        {
            try
            {
                fs = new FileStream("magazyn.txt", FileMode.Open);
                magazyn = (List<Produkt>)formater.Deserialize(fs);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        } // koniec metody

        private void Serialize()                     // METODA, KTÓRA ZAPISUJE DANE DO PLIKU 
        {
            try
            {
                fs = new FileStream("magazyn.txt", FileMode.Create);
                formater.Serialize(fs, magazyn);
                fs.Close();
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        } // koniec metody

        private void dodajButton_Click(object sender, EventArgs e)    // PRZYCISK DODAJ
        {
            Dodaj();
        }

        private void dataProdukcjiPicker_ValueChanged(object sender, EventArgs e) // ZMIANA WARTOŚCI DATY PRODUKCJI
        {
            dataWażnościPicker.MinDate = dataProdukcjiPicker.Value;
        }

        private void WszystkieCheckBox_CheckedChanged(object sender, EventArgs e) // ZMIANA WARTOŚCI CHECKBOXA WSZYSTKIE
        {
            if (WszystkieCheckBox.Checked)
            {
                for (int i = 0; i < 8; i++)
                    listaDziałów.SetItemCheckState(i, CheckState.Checked);
            }
            else
            {
                for (int i = 0; i < 8; i++)
                    listaDziałów.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void wyświetlButton_Click(object sender, EventArgs e) // PRZYCISK WYŚWIETL
        {
            Wypisz();
        }

        private void poNazwieButton_Click(object sender, EventArgs e) // PRZYCISK WYSZUKAJ PO NAZWIE
        {
            WyszukajPoNazwie(nazwaWyszukajTextBox.Text);
            nazwaWyszukajTextBox.Text = string.Empty;
        }

        private void poCenieButton_Click(object sender, EventArgs e)  // PRZYCISK WYSZUKAJ PO CENIE
        {
            WyszukajPoCenie();
        }

        private void usuńButton_Click(object sender, EventArgs e)     // PRZYCISK USUŃ
        {
            UsuńProdukt();
        }

        private void DziałBox_SelectedIndexChanged(object sender, EventArgs e) // ZMIANA DZIAŁU
        {
            if (DziałBox.Text == "Napoje")
            {
                labelPojemność.Visible = true;
                pojemnośćNumeric.Visible = true;
            }
            else
            {
                labelPojemność.Visible = false;
                pojemnośćNumeric.Visible = false;
            }

            if (DziałBox.Text == "Mięso" || DziałBox.Text == "Warzywa" || DziałBox.Text == "Owoce")
                kgLabel.Visible = true;
            else
                kgLabel.Visible = false;
        }
    }
}
