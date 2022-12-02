using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2_console_
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Введите признак транспортного средства");
            a = Convert.ToChar(Console.ReadLine());

            if (a == 'а' || a == 'А')
            {
                Console.WriteLine("Максимальная скорость автомобиля: 200 км/ч");
            }
            else if (a == 'в' || a == 'В')
            {
                Console.WriteLine("Максимальная скорость велосипеда: 40 км/ч");
            }
            else if (a == 'м' || a == 'М')
            {
                Console.WriteLine("Максимальная скорость мотоцикла: 210 км/ч");
            }
            else if (a == 'с' || a == 'С')
            {
                Console.WriteLine("Максимальная скорость самолета: 340 км/ч");
            }
            else if (a == 'п' || a == 'П')
            {
                Console.WriteLine("Максимальная скорость поезда: 200 км/ч");
            }
            else
            {
                Console.WriteLine("Неверно введен признак транспортного средства!");
            }

        }
    }
}
