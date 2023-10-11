using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint2.Task6.V5.Lib;

namespace Tyuiu.FaizullinDR.Sprint2.Task6.V5
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
            Console.WriteLine("* Задание #6                                                                           *");
            Console.WriteLine("* Вариант #5                                                                           *");
            Console.WriteLine("* Выполнил: Файзуллин Данил Рамилевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора switch,    *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                                 *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");


            Console.WriteLine("Введите номер карты:");
            int x = Convert.ToInt32(Console.ReadLine());








            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            string res = ds.FindCardValue(x);
            Console.WriteLine(res);


            Console.ReadLine();
        }
    }
}
