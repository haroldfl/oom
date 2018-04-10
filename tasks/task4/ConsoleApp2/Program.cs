using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp2;


namespace Sourcetest
{

    public enum Currency
    {
        EUR,
        USD
    }


    public class Book : IITEM
    {
        private string title;           //Beste Implemetierung da keine Bugs möglich da nicht verändert durch Private Sichtbarkeit
        private double price;           //Startet mit Private und implementiert public Konstruktor mit Regeln um keine Bugs zuzulassen
        private Currency currency;      //Felder sind defaultmäßig Private weil ich wenn public diese nicht über funktionen überprüfen kann
        private string isbn;
        private string author;

        public Currency GetCurrency() { return currency; }
        public string GetAuthor() { return author; }
        public string Title
        { get { return title; } }
        public double Price
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


        
        public string GetISBN() { return isbn; }

        public Book(string t, double p, Currency c,string isb,string aut)     //Konstruktor heißt so wie Klasse und erzeugt Element mit Parameter t p und currency C
        {
            if (t == null || t == "") throw new Exception("Leerer Titel.");         //Falscher Titel Exception wird ausgegeben
            if (isb == null || isb == "") throw new Exception("Leere ISBN");                                                                     //throw unterbricht Programmablauf und springt aus Funktion
            //if (aut == null || aut == "") throw new Exception("Kein Autor");

            title = t;
            Price = p;
            currency = c;
            isbn = isb;
            author = aut;
        }
       
    }

    class Program
    {
        static void Main(String[] args)
        {
            var items = new IITEM[]
           {
                new Book("Real-Time Rendering",12.35 , Currency.EUR,"1234556","rudi"),
                new Book("The Hitchhiker's Guide to the Galaxy",34.35, Currency.EUR,"56789","olaf"),
                new Book("C# 6.0 in a Nutshell",10.15, Currency.EUR,"78923","zottl"),
                new Book("Trillions: Thriving in the Emerging Information Ecology",67.45 , Currency.EUR,"56748","peter"),
                new Book("Cryptonomicon",99.80 , Currency.EUR,"98767","Franz")   
           };
            Serilization.Run(items);


        }
        
    }
}
