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
            string s = "Эта статья о том, как {начинающим {раз}работчикам} оформить {профиль на GitHub";
            int[] a = new int[s.Length]; //массив для хранения номеров индексов длиною с первоначальный
            int ind = 0;
            int i = 0;
            Console.WriteLine("Первоначальная строка: {0}", s);

            while (i < s.Length)
            {
                if (s[i] == '{')
                    a[ind++] = i;
                if (s[i] == '}' && ind > 0)   //если есть закрытая и хоть одна открытая скобка
                {
                    int startIndex = a[ind - 1];
                    int count = i - a[ind - 1] + 1;
                    s = s.Remove(startIndex, count);
                    i = startIndex - 1;
                    ind--;
                }
                i++;
            }


            Console.WriteLine("Удален текст взятый в фигурные скобки: {0}", s);

            Console.ReadKey();
        }
    }
}
/*Спасибо большое Екатерине Швец за подробное описание этой задачи на вебинаре 11.12.2021*/