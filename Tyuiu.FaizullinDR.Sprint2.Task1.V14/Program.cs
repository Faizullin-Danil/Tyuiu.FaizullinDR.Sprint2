using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint2.Task1.V14.Lib;

namespace Tyuiu.FaizullinDR.Sprint2.Task1.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);

            Console.Title = "Спринт #2 | Выполнил: Файзуллин Д. Р. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                            *");
            Console.WriteLine("* Тема: Операции сравнения                                                             *");
            Console.WriteLine("* Задание #1                                                                           *");
            Console.WriteLine("* Вариант #14                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                      *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении)           *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна     *");
            Console.WriteLine("* нарушаться), а также арифметических выражений, которая вернет логическую             *");
            Console.WriteLine("* последовательность(массив): (False, True, True, True, True, False),                  *");
            Console.WriteLine("* при a = 185, b = 216, c = 174, d = 917                                               *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);




            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}
