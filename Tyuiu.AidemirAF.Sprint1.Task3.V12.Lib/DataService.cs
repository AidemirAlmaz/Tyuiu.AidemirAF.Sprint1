﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AidemirAF.Sprint1.Task3.V12.Lib
{
    public class DataService : ISprint1Task3V12
    {
        public double TriangleArea(double lengthCathetus1, double lengthCathetus2)
        {
            double res = Math.Round(lengthCathetus1 * lengthCathetus2 / 2, 3);
            return res;
        }
    }
}
