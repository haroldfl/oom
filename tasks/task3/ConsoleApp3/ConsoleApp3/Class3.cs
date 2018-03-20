using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson3
{
    public enum Currency
    {
        EUR,
        USD
    }

    public class Book : IItem
    {
        private string title;           //Beste Implemetierung da keine Bugs möglich da nicht verändert durch Private Sichtbarkeit
        private decimal price;           //Startet mit Private und implementiert public Konstruktor mit Regeln um keine Bugs zuzulassen
        private Currency currency;      //Felder sind defaultmäßig Private weil ich wenn public diese nicht über funktionen überprüfen kann
        private string description;

        public decimal GetPrice(Currency currency) { return price; }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {

                if (value < 0) throw new Exception("Neg. Preis");
                price = value;


            }



        }


        public string GetTitle() { return title; }
        public void SetPrice(decimal newPrice)
        {
            if (newPrice < 0) throw new Exception("Neg. Preis");
            price = newPrice;
        }

        public string Description { get { return description; } }


        public Book(string t, decimal p, Currency c, string d)     //Konstruktor heißt so wie Klasse und erzeugt Element mit Parameter t p und currency C
        {
            if (t == null || t == "") throw new Exception("Leerer Titel.");         //Falscher Titel Exception wird ausgegeben
                                                                                    //throw unterbricht Programmablauf und springt aus Funktion
            SetPrice(p);

            title = t;
            price = p;
            currency = c;
            description = d;
        }
    }
}
