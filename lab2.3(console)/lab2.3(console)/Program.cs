using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._3_console_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Способ 1
            for (int i = 10; i < 100; i++)
            {
                if (Math.Abs(i % 10 - (i - i % 10) / 10) <= 1)
                    Console.WriteLine(i);
            }
            // Способ 2
            int j = 10;
            while (j < 100)
            {
                if (Math.Abs(j % 10 - (j - j % 10) / 10) <= 1)
                    Console.WriteLine(j);
                j++;
            }
            // Способ 3
            int k = 10;
            do
            {
                if (Math.Abs(k % 10 - (k - k % 10) / 10) <= 1)
                    Console.WriteLine(k);
                k++;
            }
            while (k < 100);

        }
    }
}
