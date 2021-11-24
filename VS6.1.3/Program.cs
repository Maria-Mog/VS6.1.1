using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS6._1._3
{
    class Program
    {
        //Определтть является ли строка палиндромом
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести предложение, слова разделить пробелом, знаки препинания не использовать");
            string text = Console.ReadLine();
            string text1 = text.ToLower(); //убрать заглавные буквы
            string[] textArrey = text1.Split();
            string text2 = string.Join("", textArrey); //соединить слова (запись без пробелов)
            bool f = false;
            for (int i = 0; i < text2.Length / 2; i++)
            {
                if (text2[i] != text2[text2.Length - i - 1])
                {
                    Console.WriteLine("Не палиндром");
                    f = true;
                    break;
                }
            }
            if (!f)               
            Console.WriteLine("Палиндром");
            Console.ReadKey();


        }
    }
}
