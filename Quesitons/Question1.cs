using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesitons
{
    internal class Question1
    {
        //Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.
        public void GetOrder()
        {
            Console.Write("Sipariş no giriniz (1-3) : ");
            int orderNo = int.Parse(Console.ReadLine());

            switch (orderNo)
            {
                case 1:
                    Console.WriteLine("Laptop siparişiniz alınmıştır");
                    break;
                case 2:
                    Console.WriteLine("Kulaklık siparişiniz alınmıştır");
                    break;
                case 3:
                    Console.WriteLine("Monitör siparişiniz alınmıştır");
                    break;
                default:
                    Console.WriteLine("Tanımsız sipariş numarası");
                    break;
            }
        }
    }
}
