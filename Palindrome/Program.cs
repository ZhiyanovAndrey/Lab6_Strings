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

            //string resultString="";
            //int max = 0;
            bool Palindrome = true;

            string delSpaces = str.Replace(" ", "");
            string resultString = delSpaces.ToUpper();

            char[] s = resultString.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s.Length - i) Palindrome = false;

                Console.WriteLine(s[i]);
            }



            Console.WriteLine(Palindrome);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
