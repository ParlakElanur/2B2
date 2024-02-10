using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesitons
{
    internal class Question6
    {
        //Bir mağazada alınan ürünün fiyatı 300 tl üzerinde ise 50 tl olan kargo ücreti alınmamaktadır. ürünün fiyatı girildiğinde toplam ödemesi gereken tutarı gösteren programı yazınız.
        public void GetOrder()
        {
            Console.WriteLine("Ürün fiyatını giriniz : ");
            int productPrice = Convert.ToInt32(Console.ReadLine());

            int shippingCost = 50;
            if (productPrice < 300)
            {
                productPrice += shippingCost;
                Console.WriteLine($"Ödenecek tutar : {productPrice}");
            }
            else
            {
                Console.WriteLine($"Ödenecek tutar : {productPrice}");
            }


        }
    }
}
