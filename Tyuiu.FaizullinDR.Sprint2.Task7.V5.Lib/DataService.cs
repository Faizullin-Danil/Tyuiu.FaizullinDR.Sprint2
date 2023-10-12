﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FaizullinDR.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y<Math.Exp(x))&&(y < Math.Exp(-x))&&(y>x*x))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
