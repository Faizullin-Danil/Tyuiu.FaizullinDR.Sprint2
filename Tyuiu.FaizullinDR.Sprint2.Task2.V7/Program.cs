using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint2.Task2.V7.Lib;

namespace Tyuiu.FaizullinDR.Sprint2.Task2.V7
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
            Console.WriteLine("* Задание #2                                                                           *");
            Console.WriteLine("* Вариант #7                                                                           *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры               *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной области.          *");   
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            Console.WriteLine("Введите координату X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y:");
            int y = Convert.ToInt32(Console.ReadLine());





            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine(res);


            Console.ReadLine();
        }
    }
}
