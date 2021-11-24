using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS6._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести предложение, слова разделить пробелом, знаки препинания не использовать");
            string str = Console.ReadLine();
            //string[] strArrey = str.Split();
            //string rez = "";
            int lb = str.IndexOf("{");
            int rb = str.LastIndexOf("}");
            while (true)
            {
                str = str.Remove(str.IndexOf("{"), str.LastIndexOf("}") - str.IndexOf("{"));
            }
            
            /*for (int i = 0; i < str.Length; i++)
            {
                if ((rb < 0) || (lb < 0))
                {
                    break;

                }
                str = str.Substring(lb, rb - lb);


            }*/
            //str = str.Remove(lb, rb - lb);
            Console.WriteLine(str);
            Console.ReadKey(); ;
        }
        
        
    }
}
