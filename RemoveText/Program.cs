using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Из строки требуется удалить текст, заключенный в фигурные скобки.
 * В строке может быть несколько фрагментов, заключённых в фигурные скобки.
 * Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.*/
namespace RemoveText
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Эта статья о том, как {начинающим разработчикам} оформить профиль на GitHub";
            string resultString = "";
            //string s=line.Split();
            Console.WriteLine("Первоначальная строка: {0}", s);

            
            int foundS1 = s.IndexOf("{");
            int foundS2 = s.IndexOf("}", foundS1 + 1);

            if (foundS1 != foundS2 && foundS1 >= 0)
            {

                resultString = s.Remove(foundS1, foundS2 - foundS1 + 1);

                Console.WriteLine("Удален текст взятый в фигурные скобки: {0}", resultString);
            }


            int S1 = resultString.IndexOf("{");
            int S2 = resultString.IndexOf("}", S1 + 1);

            if (S1 != S2 && S1 >= 0)
            {

                resultString = resultString.Remove(S1, S2 - S1 + 1);

                Console.WriteLine("After removing the middle name, we are left with '{0}'", resultString);
            }
            Console.ReadKey();
        }
    }
}
/*Можно ли решить задачу методами String, не соображу как добавить цикл, выполнил только для двух повторений?
 Или надо применять StringBuilder. (есть готовое решение, но захотелось помучаться!)*/