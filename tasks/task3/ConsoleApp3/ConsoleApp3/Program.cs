
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
                var items = new Person[]
            {
                new Family("Huber","Kirchenstrasse",12,false),
                new Family("Meier", "Schulstrasse", 15, true),
                new Customer("Wurst",1234,2,"Schulstrasse"),
                new Customer("Schinken",3421,10,"Tischlerweg"),
            };
              
                
                foreach (var x in items)
                {
                    Console.WriteLine($"{x.Surname} {x.Address}");
                }
            }

            
            catch (Exception e)      //Behandeln der Exception aus Konstruktor
            {
                Console.WriteLine($"catch:{ e.Message}");       //Ausgabe der Fehlermeldung Exception


            }
            
            

        }
    }
}
   
