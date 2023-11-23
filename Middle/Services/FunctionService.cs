using Middle.Models;
using System;
using System.Collections.Generic;

namespace Middle.Services
{
    public static class FunctionService
    {
        public static List<Point> CalculateFunction(Func<double, double> func, double left, double right, double step)
        {
            int i = 0;

            List<Point> result = new List<Point>();

            for (double x = left; x <= right + step; x += step)
            {
                result.Add(new Point(x, func(x)));
                i++;
            }

            return result;
        }
    }
}
