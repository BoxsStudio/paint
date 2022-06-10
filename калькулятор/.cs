using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace калькулятор
{
    internal class Program
    {

        public int wow = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("введите 1 число:");
            int nomer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите знак");
            string nom = Console.ReadLine();
            Console.WriteLine("введите 2 число:");
            int nomer2 = Convert.ToInt32(Console.ReadLine());
            if (nom == "+")
            {
                int wow = nomer1 + nomer2;
                Console.WriteLine("                 " + nomer1);
                Console.WriteLine("                +");
                Console.WriteLine("                 " + nomer2);
                Console.WriteLine("                 -------------------------");
                Console.WriteLine("                 " + wow);
            }
            if (nom == "-")
            {
                int wow = nomer1 - nomer2;
                Console.WriteLine("                 " + nomer1);
                Console.WriteLine("                -");
                Console.WriteLine("                 " + nomer2);
                Console.WriteLine("                 -------------------------");
                Console.WriteLine("                 " + wow);
            }
            if (nom == "x")
            {
                int wow = nomer1 * nomer2;
                Console.WriteLine("                 " + nomer1);
                Console.WriteLine("                x");
                Console.WriteLine("                 " + nomer2);
                Console.WriteLine("                 -------------------------");
                Console.WriteLine("                 " + wow);
            }
            if (nom == "/")
            {
                int wow = nomer1 / nomer2;
                string a = Convert.ToString(wow);

                Console.WriteLine("                 " + nomer1 + "|_" + nomer2 + "___");
                Console.WriteLine("                     "+ wow );
                for (int i = 0; i < a.Length; i++)
                {
                    var output = Regex.Replace(a.Split()[i], @"[^0-9a-zA-Z\ ]+", "");
                    int das = Convert.ToInt32(output);
                    int ops = das * nomer2;
                    Console.WriteLine("                 "+ ops);
                }
                


               
                
                Console.WriteLine("                 -------------------------");
                Console.WriteLine("                 " + 0);
            }


        }
    }
}
