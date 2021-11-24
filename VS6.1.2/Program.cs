using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS6._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести предложение, слова разделить пробелом, знаки препинания не использовать");
            string s = Console.ReadLine();
            //string[] s = startString.Split();            
            //int maxString = 0, nomerString=0;
            bool f = false;
            for (int i = 0, j = s.Length - 1; i < j; i++, j++)
            {
                if (s[i] != s[j])
                {
                    Console.WriteLine("Полиндром");
                    f = true;
                    break;
                }

            }
            if (!f)
            Console.WriteLine("Не полиндром");
            Console.ReadKey();
        }
        /*for (int i = 0; i<s.Length / 2; i++)
 
        if (s[i] != s[s.Length - i - 1])*/
    }
}
