using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Strings
{
    class Program
    {
        /*Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
         * Знаки препинания не используются. Найти самое длинное слово в строке. */
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] stringArray = str.Split();
            string longestWord = "";
            int max = 0;
            foreach (string s in stringArray)
            {
                if (s.Length > max) max = s.Length;
                if (s.Length == max) longestWord = s.Substring(0);

            }



            Console.WriteLine("Самое длинное слово: " + longestWord +
            "\nКоличество символов: " + max);
            Console.ReadKey();
        }
    }
}

