
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;


namespace lesson3
{
    

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var items = new IItem[]
            {
                new Book("Real-Time Rendering", 123,Currency.EUR,"blabla"),
                new Book("Real-Time", 135,Currency.USD,"blabla"),
                new Book("Time Rendering", 130,Currency.USD,"blabla"),
                new Book("Time ring", 10,Currency.EUR,"blabla"),
                new Book("Rendering", 12,Currency.EUR,"blabla"),
                new GiftCard(50, Currency.EUR),
                new GiftCard(10, Currency.USD),
                new GiftCard(100, Currency.EUR),
            };

                var currency = Currency.EUR;
                foreach (var x in items)
                {
                    Console.WriteLine($"{x.Description.Truncate(50),-50} {x.GetPrice(currency),8:0.00} {currency}");
                }
            }

            
            catch (Exception e)      //Behandeln der Exception aus Konstruktor
            {
                Console.WriteLine($"catch:{ e.Message}");       //Ausgabe der Fehlermeldung Exception


            }
            Console.WriteLine("Fertig");
            //a.title = "ABC";        // nicht möglich wenn title private .... kann nur in Class Book geändert werden

        }
    }
}
   
