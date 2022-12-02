using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._4_console_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            double x = 1;
            int flag = 0;

            while (a - 5 > 0)
            {
                if (flag == 0)
                {
                    Console.Write(a);
                    flag = 1;
                }
                else
                {
                    
                    for (double i = 1.1; i <= x; i++)
                        Console.Write(a + " ");
                    Console.WriteLine();
                    for (int j = 1; j <= x; j++)
                        Console.Write(a - 5 + " ");
                    Console.WriteLine();

                    x += 1.5;
                    a--;
                }
            }

        }
    }
}
