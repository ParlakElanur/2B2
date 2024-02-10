using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesitons
{
    internal class Question8
    {
        // 1-200 arası içinde 3'e veya 5'e tam bölünebilen sayıları listeleyen ve kaç adet olduğunu yazdıran programı yazınız.
        public void GetNumber()
        {
            int count = 0;
            string numbers = "";
            for (int i = 1; i <= 200; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    count++;
                    numbers += i.ToString();
                }

            }
            Console.WriteLine($"3'e veya 5'e tam bölünebilen sayılar : {numbers}");
            Console.WriteLine($"3'e veya 5'e tam bölünebilen sayı adedi : {count}");
        }
    }
}
