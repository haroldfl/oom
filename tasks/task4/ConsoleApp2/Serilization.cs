using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp2
{
    class Serilization
    {
        public static void Run(IITEM[] items)
        {
            var book = items[0];
            
            // 1. serialize a single book to a JSON string
            Console.WriteLine(JsonConvert.SerializeObject(book));

            // 2. ... with nicer formatting
            Console.WriteLine(JsonConvert.SerializeObject(book, Formatting.Indented));

            // 3. serialize all items
            // ... include type, so we can deserialize sub-classes to interface type
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(items, settings));

            // 4. store json string to file "items.json" on your Desktop
            var text = JsonConvert.SerializeObject(items);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "items.json");
            File.WriteAllText(filename, text);

            // 5. deserialize items from "items.json"
            // ... and print Description and Price of deserialized items
            var textFromFile = File.ReadAllText(filename);
            Console.WriteLine(textFromFile);
            var itemsFromFile = JsonConvert.DeserializeObject<IITEM[]>(textFromFile,settings);
            
         // foreach (var x in itemsFromFile) Console.WriteLine($"{x.Title} {x.Price}");
  
        }
    }
}
