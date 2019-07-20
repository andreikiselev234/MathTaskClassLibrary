using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleArea(int a, int b)
        { 
            return a * b;
        }
        public double CircleArea(int r)
        {
            const double pi = 3.14;
            return pi* Math.Pow(r,2);
        }
        public double TriangleArea(int a, int b, int c)
        {
            double p = (double)((double)(a+b+c)/2);
            p = Math.Round(p, 6);
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Math.Round(s, 6);
            
        }
        public double EllipseArea(int r, int R)
        {
            const double pi = 3.14;
            return pi * r * R;
        }
        public double DiamondArea(int d1, int d2)
        {
            return (double)((double)d1*d2/2);
        }
        public int ParallelogramArea(int a, int h)
        {
            return a*h;
        }
        public double TrapezoidArea(int a, int b, int h)
        {
            double p = (double)(a + b) / 2;
            return p*h;
        }
        public double СonvexQuadrangleArea(int d1, int d2, double angle)
        {
            double radian = (double) ((double)(angle * Math.PI) / 180);
            double s = (double)((Double)d1*(double)d2/2* Math.Sin(radian));
            return s;
        }

    }
}
