using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1_console_
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("Введите x и y");
            try
            {
                x = float.Parse(Console.ReadLine());
                y = float.Parse(Console.ReadLine());

                if ((y > 0 && y < 5) && (x > 0 && x < 10))
                {
                    Console.WriteLine("Да");
                }
                else if ((y == 5 && (x >= 0 && x <= 10) || x == 10 && (y >= 0 && (y >= 0 && y <= 5))) || (((y <= 5) || (x <= 10)) && ((y >= 0) && (x >= 0))))
                {
                    Console.WriteLine("На границе");
                }
                else
                {
                    Console.WriteLine("Нет");
                }

            }
            catch
            {
                Console.WriteLine("Введен неверный символ!");
            }

        }
    }
}
