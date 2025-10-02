using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnkelProduktKatalog
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        public double TotPrice;

        public void ReadInfo()
        {
            Console.WriteLine("\nVad är det för produkt?");
            Name = Console.ReadLine();

            Console.WriteLine("\nVad ska produkten kosta?");
            Price = Convert.ToDouble(Console.ReadLine().Replace('.',','));

            Console.WriteLine("\nHur många finns det?");
            Quantity = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintInfo()
        {
            Console.WriteLine($"-----Produkt:-{Name}-----Pris:-{Price}kr-----Antal:-{Quantity}st-----");
        }

        public void GetTotalPrice()
        {
            TotPrice = Convert.ToDouble(Price * Quantity);

            Console.WriteLine($"Räknar ut totala kosntanden för {Name}---");
            Thread.Sleep(500);
            Console.WriteLine($"Räknar ut totala kosntanden för {Name}--- --- ---");
            Thread.Sleep(500);
            Console.WriteLine($"Räknar ut totala kosntanden för {Name}--- --- --- --- ---");
            Thread.Sleep(500);
            Console.WriteLine($"Räknar ut totala kosntanden för {Name}--- --- --- --- --- --- ---");
            Thread.Sleep(500);
            Console.WriteLine($"Räknar ut totala kosntanden för {Name}--- --- --- --- --- --- --- --- ---");
            Thread.Sleep(500);
            Console.WriteLine($"Räknar ut totala kosntanden för {Name}--- --- --- --- --- --- --- --- --- --- ---");
            Thread.Sleep(500);
            Console.WriteLine($"\nDen totala kostnaden för produkten {Name} är {TotPrice}kr");
            Thread.Sleep(500);


        }
        public static void GetTotalPriceAll(Product Produkt1, Product Produkt2)
        {
            double TotPriceAll = Produkt1.TotPrice + Produkt2.TotPrice;
            Console.WriteLine($"\nTotalt har båda produkterna en total kostnad på {TotPriceAll}kr");
        }

        public static void WriteFile(Product Produkt1, Product Produkt2)
        {
         string File1 = $"\nInfo Produkt 1 --- Produkt-Namn: {Produkt1.Name}, Produkt-Pris: {Produkt1.Price}kr, Produkt-Kvantitet: {Produkt1.Quantity}st | Info Produkt 2 --- Produkt-Namn: {Produkt2.Name}, Produkt-Pris:{Produkt2.Price}kr, Produkt-Kvantitet: {Produkt2.Quantity}st";
            Console.WriteLine($"{File1}");
            File.WriteAllText($"Senaste_inventeringen_{DateTime.Now:yyyy-MM-dd-HH-mm}.txt", File1);
            Console.WriteLine("\nFil med senaste inventering skapad!");
        }



    }
}
