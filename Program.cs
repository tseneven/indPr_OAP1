using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prKol_ind1_Kuznetsov_A_Pr_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> strings = new Stack<string>();
            StreamReader sr = new StreamReader("txt.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                strings.Push(str);
            }
            Stack<string> reversedStack = new Stack<string>();
            while(strings.Count > 0)
            {
                reversedStack.Push(strings.Pop());
            }

            for (int j = 0; j < reversedStack.Count; j++)
            {
                string Stroka = reversedStack.Pop();
                for (int i = Stroka.Length-1; i >= 0; i--)
                {
                    if (!char.IsDigit(Stroka[i]))
                    {
                        Console.WriteLine(Stroka[i]);
                    }
                }
                Console.WriteLine("Нажмите Enter для вывода следующей строки");
                Console.ReadKey();
            }

            Console.ReadKey();

        }
    }
}
