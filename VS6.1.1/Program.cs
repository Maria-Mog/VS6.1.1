
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS6._1._1
{
    class Program
    {
        //Найти самое длинное слово в строке
        static void Main(string[] args)
        {
            //введем строку, методом Split разобьем ее в массив отдельных слов, циклом переберем массив, считая количество знаков, выберем наибольшее
            Console.WriteLine("Ввести предложение, слова разделить пробелом, знаки препинания не использовать");
            string startString = Console.ReadLine();
            string[] strinArray = startString.Split();            
            int maxString = 0, nomerString=0;

            for (int i = 0; i <strinArray.Length; i++)
            {
                if (strinArray[i].Length>maxString)
                {
                    maxString = strinArray[i].Length;
                    nomerString = i;
                }
                
            }          
            Console.WriteLine("Самое длинное слово в предложении {0} ",  strinArray[nomerString]);
            Console.ReadKey();
        }
    }
}
