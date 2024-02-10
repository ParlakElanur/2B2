using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesitons
{
    internal class Question4
    {
        //Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.
        public void IsPerfect()
        {
            Console.Write("Bir sayı giriniz");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int i = 1;
            while (i < number)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
                i++;
            }
            if (i == sum)
                Console.WriteLine($"{number} mükemmel sayıdır");
            else
                Console.WriteLine($"{number} mükemmel sayı değildir");
        }
    }
}
