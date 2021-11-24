using System;

namespace VS6._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести предложение, слова разделить пробелом, знаки препинания не использовать");
            string s = Console.ReadLine();            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{')
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] == '}')
                        {

                             s = s.Substring(0, i) + s.Substring(j + 1)+ ' ';
                             break;
                         
                            
                        }
                    }
                    
                }

            }
            Console.WriteLine(s);            
            Console.ReadKey();
        }
    }
}
