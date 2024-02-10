using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesitons
{
    internal class Question7
    {
        //iki ürünün kullanıcı tarafından fiyatı girildiğinde toplam fiyat 500 tl'den fazla ise 2.üründen %40 indirim yaparak ödenecek tutarı gösteren uygulamayı yazınız.
        public void GetTotalPrice()
        {
            double firstPrice, secondPrice;
            double totalPrice = 0;

            Console.Write("1. ürünün fiyatı :");
            firstPrice = int.Parse(Console.ReadLine());

            Console.Write("2. ürünün fiyatı :");
            secondPrice = int.Parse(Console.ReadLine());

            totalPrice = firstPrice + secondPrice;
            if (totalPrice > 500)
            {
                secondPrice = secondPrice - secondPrice * (0.4);
                totalPrice = firstPrice + secondPrice;
            }

            Console.WriteLine($"Ödenecek tutar toplam : {totalPrice}");
        }
    }
}
