using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler; Sepete eklendi " + product.Name);
        }

        public void Ekle2(string Name, string Description, double Price, int StokAdedi)
        {
            Console.WriteLine("Tebrikler; Sepete eklendi " + Name);
        }
    }
}
