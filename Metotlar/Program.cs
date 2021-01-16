using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Product urun1 = new Product();
            urun1.Name = "Elma";
            urun1.Price = 15;
            urun1.Description = "Amasya elması";

            Product urun2 = new Product();
            urun2.Name = "Karpuz";
            urun2.Price = 80;
            urun2.Description = "Diayarbakır karpuzu";

            Product[] products = new Product[] {urun1,urun2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("................Metotlar........");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Kayseri armut", 15, 20);
        }
    }
}
