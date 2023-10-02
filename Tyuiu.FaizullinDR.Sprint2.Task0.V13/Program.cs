using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint2.Task0.V13.Lib;

namespace Tyuiu.FaizullinDR.Sprint2.Task0.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1905;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил: Файзуллин Д. Р. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                            *");
            Console.WriteLine("* Тема: Операции сравнения                                                             *");
            Console.WriteLine("* Задание #0                                                                           *");
            Console.WriteLine("* Вариант #13                                                                          *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,                      *");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических выражений,        *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                                *");
            Console.WriteLine("* (False, True, False, True, False, True), при x = 1905, y = 475                       *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

  


            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            for (int i = 0;i<6;i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();

        }
    }
}
