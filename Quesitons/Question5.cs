using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quesitons
{
    internal class Question5
    {
        //String metotlarını araştırınız. Her bir metot için örnek yapınız.
        public void GetStringMethods()
        {
            string text = " AspNet Core MVC ";

            Console.WriteLine($"Orjinal metin : {text}");

            Console.WriteLine($"Trim : {text.Trim()}");

            Console.WriteLine($"SubString : {text.Substring(7)}");

            Console.WriteLine($"IndexOf : {text.IndexOf('e')}");

            Console.WriteLine($"Remove : {text.Remove(4)}");

            Console.WriteLine($"Contains : {text.Contains('o')}");

            Console.WriteLine($"Replace : {text.Replace(' ', '_')}");

            Console.Write($"Split : ");
            string[] splitText = text.Split(' ');
            foreach (string s in splitText)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();

            Console.WriteLine($"ToLower : {text.ToLower()}");

            Console.WriteLine($"ToUpper : {text.ToUpper()}");

        }
    }
}
