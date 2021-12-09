using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
        * Знаки препинания не используются. Составить программу, оределяющую является ли строка палиндромом 
        * без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»)*/
namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();


            bool Palindrome = true;

            string delSpaces = str.Replace(" ", "");
            string resultString = delSpaces.ToUpper();

            char[] s = resultString.ToCharArray();


            for (int i = 0; i < s.Length; i++)
            {
                //Console.WriteLine(s[i]);

                int a = s.Length - 1 - i; //перевернутая строка

                Console.WriteLine(s[a]);

                if (s[i] != s[a]) Palindrome = false;

            }

            if (Palindrome) Console.WriteLine("Строка является палиндромом");
            else Console.WriteLine("Строка не является палиндромом");



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
