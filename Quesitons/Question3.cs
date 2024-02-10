using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesitons
{
    internal class Question3
    {
        //Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.
        public void GetLoop()
        {
            // While - C# programında verilen koşul sağlanıyor iken dönmeye devam eden döngülere denir.

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // Do-While - Koşulun doğruluğunu kontrol etmeden en az bir kere çalıştırılması istenilen durumlarda kullanılır.

            int j = 5;
            do
            {
                Console.WriteLine(j);
                j++;

            } while (j < 5);
        }
    }
}
