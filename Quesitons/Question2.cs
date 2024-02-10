using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesitons
{
    internal class Question2
    {
        //Kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız.(döngü için for döngüsü kullanınız)
        public void GetOrderTotal()
        {
            Console.WriteLine("Kaç ürün almak istiyorsunuz? ");

            int quantity = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < quantity; i++)
            {
                Console.Write($"{i}. ürünün fiyatı : ");
                total += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Toplam tutar : {total}");


        }
    }
}
