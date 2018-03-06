using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace life
{
    public class Priv_life
    {

        private string title;
        private int isbn;
        private double price;


        public Priv_life(string t, double p, int a)     //Konstruktor heißt so wie Klasse und erzeugt Element mit Parameter t p und currency C
        {
            if (t == null || t == "") throw new Exception("Leerer Titel.");         //Falscher Titel Exception wird ausgegeben
                                                                                    //throw unterbricht Programmablauf und springt aus Funktion
            

            title = t;
            price = cal_Price(p);
            isbn = a;
        }


        public double cal_Price(double newPrice)
        {
            if (newPrice < 0) throw new Exception("Neg. Preis");
            newPrice += ((newPrice / 100) * 20);
            return newPrice;
        }
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
                price=cal_Price(price);

            }

        }
        public double ISBN
        {
            get
            {
                return isbn;
            }
            set
            {

                if (value < 0) throw new Exception("Neg. ISBN");
                isbn = (int)value;

            }

        }

    }







    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Priv_life a = new Priv_life("bla",12.5,1234567); //Objekt a anlegen vom Datentyp Book
                Console.WriteLine($"old Price: {a.Price}\n old ISBN: {a.ISBN}\n");
                a.Price = 13.5;
                a.ISBN = 4567;
                Console.WriteLine($"Price: {a.Price}\n ISBN: {a.ISBN}");
            }
            catch (Exception e)      //Behandeln der Exception aus Konstruktor
            {
                Console.WriteLine($"catch:{ e.Message}");       //Ausgabe der Fehlermeldung Exception


            }
            Console.WriteLine("Fertig");
        }
    }

}