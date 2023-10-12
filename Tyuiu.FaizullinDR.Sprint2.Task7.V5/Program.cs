using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint2.Task7.V5.Lib;

namespace Tyuiu.FaizullinDR.Sprint2.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнил: Файзуллин Д. Р. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                            *");
            Console.WriteLine("* Тема: Операции сравнения                                                             *");
            Console.WriteLine("* Задание #7                                                                           *");
            Console.WriteLine("* Вариант #5                                                                           *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные значения)*");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.         *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            Console.WriteLine("Введите X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y:");
            double y = Convert.ToDouble(Console.ReadLine());








            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            bool res = ds.CheckDotInShadedArea(x,y);
            if (res)
            {
                Console.WriteLine("точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("точка не находится в заштрихованной области");
            }


            Console.ReadLine();
        }
    }
}
