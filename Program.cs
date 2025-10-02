using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnkelProduktKatalog
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till ProduktKatalogen! Tryck på valfri knapp för att forstätta!");
            Console.ReadKey();

            Product Produkt1 = new Product();

            Produkt1.ReadInfo();
            Produkt1.PrintInfo();
            Produkt1.GetTotalPrice();

            Console.WriteLine("\nTryck på valfri knapp för att lägga till en till produkt!");
            Console.ReadKey();

            Product Produkt2 = new Product();
            Produkt2.ReadInfo();
            Produkt2.PrintInfo();
            Produkt2.GetTotalPrice();

            Product.GetTotalPriceAll(Produkt1, Produkt2);
            Product.WriteFile(Produkt1, Produkt2);
        }
       
    }
}
