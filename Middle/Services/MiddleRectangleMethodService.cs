using Middle.Models;
using System;
using System.Collections.Generic;

namespace Middle.Services
{
    public static class MiddleRectangleMethodService
    {
        private static double FindIntegral(double leftBorder, double rightBorder, double h, Func<double, double> func)
        {
            double result = 0;
            for (double x = leftBorder + h / 2.0; x < rightBorder; x += h)
                result += func(x);
            return result *= h;
        }

        public static List<Point> RectanglesPoints(double leftBorder, double rightBorder, double h, Func<double, double> func)
        {
            List<Point> result = new List<Point>();
            int i = 1;
            for (double x = leftBorder + h / 2.0, xx = leftBorder; x < rightBorder; x += h, xx += h)
            {
                double step = 0.5;
                double y = func(x);
                if (y > 0)
                {
                    for (double rectangleY = 0; rectangleY <= y; rectangleY += step)
                        result.Add(new Point(xx, rectangleY));
                    for (double rectangleX = leftBorder + h * (i - 1); rectangleX <= leftBorder + h * i; rectangleX += step)
                        result.Add(new Point(rectangleX, y));
                    for (double rectangleY = y; rectangleY >= 0; rectangleY -= step)
                        result.Add(new Point(xx + h, rectangleY));
                }

                else 
                {
                    for (double rectangleY = 0; rectangleY >= y; rectangleY -= step)
                        result.Add(new Point(xx, rectangleY));
                    for (double rectangleX = leftBorder + h * (i - 1); rectangleX <= leftBorder + h * i; rectangleX += step)
                        result.Add(new Point(rectangleX, y));
                    for (double rectangleY = y; rectangleY <= 0; rectangleY += step)
                        result.Add(new Point(xx + h, rectangleY));
                }
                result.Add(new Point(xx + h, 0));

                i++;
            }

            return result;
        }
        public static List<Point> KeyPoints(double leftBorder, double rightBorder, double h, Func<double, double> func)
        {
            List<Point> result = new List<Point>();

            for (double x = leftBorder + h / 2.0; x < rightBorder; x += h)
            {
                for (int i = 0; i < 5; i++)
                    result.Add(new Point(x, func(x)));
            }

            return result;
        }
        public static List<Point> LinesPoints(double leftBorder, double rightBorder, double h, Func<double, double> func)
        {
            List<Point> result = new List<Point>();
            double step = 0.3;
            for (double x = leftBorder + h / 2.0; x < rightBorder; x += h)
            {
                if (func(x) > 0)
                    for (double lineY = func(x); lineY >= 0; lineY -= step)
                        result.Add(new Point(x, lineY));
                else
                    for (double lineY = func(x); lineY <= 0; lineY += step)
                        result.Add(new Point(x, lineY));

                if (result.Count % 2 != 0)
                    result.Add(new Point(x, 0));
            }

            return result;
        }
        public static List<Point> ALotOfRectangles(double leftBorder, double rightBorder, double h, Func<double, double> func)
        {
            List<Point> result = new List<Point>();
            int i = 1;
            for (double x = leftBorder + h / 2.0, xx = leftBorder; x < rightBorder; x += h, xx += h)
            {
                double y = func(x);

                result.Add(new Point(xx, 0));
                result.Add(new Point(xx, y));
                result.Add(new Point(leftBorder + h * (i - 1), y));
                result.Add(new Point(leftBorder + h * i, y));
                result.Add(new Point(xx + h, y));
                result.Add(new Point(xx + h, 0));

                i++;
            }

            return result;
        }

        public static double MiddleRectagleMethod(double leftBorder, double rightBorder, double eps, Func<double, double> func, out bool isFine, out int N)
        {
            isFine = true;
            N = 10;
            double h = (rightBorder - leftBorder) / N;
            double I0 = 0, I1 = 0;
            double d1 = 0, d2 = 0;

            I0 = FindIntegral(leftBorder, rightBorder, h, func);

            N *= 2;
            h = (rightBorder - leftBorder) / N;

            I1 = FindIntegral(leftBorder, rightBorder, h, func);

            d1 = Math.Abs(I1 - I0);

            while (d1 / 3.0 >= eps)
            {
                I0 = I1;

                N *= 2;
                h = (rightBorder - leftBorder) / N;

                I1 = FindIntegral(leftBorder, rightBorder, h, func);

                d2 = Math.Abs(I1 - I0);

                if (d1 < d2)
                {
                    isFine = false;
                    return I1;
                }

                d1 = d2;

            }
            
            return I1;
        }
    }
}
