using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;


namespace Task5
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

        public Book(string t, double p, Currency c, string isb, string aut)     //Konstruktor heißt so wie Klasse und erzeugt Element mit Parameter t p und currency C
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
            //Implementierung von Enumerator
            var zahlen = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var e = zahlen.GetEnumerator();
            while (e.MoveNext()) Console.WriteLine(e.Current);

            //Mittels I-Enumerable Funktion
            var ersten_n_zahlen = nummern().Take(5).Skip(2);

            foreach (var i in ersten_n_zahlen)
            {
                Console.WriteLine(i);
            }
            // Implemetierung Events

            var window = new Form() { Text = "window 1", Width = 500, Height = 600 };
            window.MouseMove += (sender, eventArgs) => WriteLine($"[MouseMove event] ({eventArgs.X}, {eventArgs.Y})");
            Application.Run(window);

            IObservable<Point> moves = Observable.FromEventPattern<MouseEventArgs>(window, "MouseMove")
            .Select(x => x.EventArgs.Location) // ... only interested in the position
    ;


            //Serilization.Run(items);


        }
        public static IEnumerable<int> nummern()
        {
            int i = 1;
            while (true) yield return i++;
        }
        public event MouseEventHandler MouseMove;
    }
}
