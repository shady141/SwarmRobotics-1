using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Triangle
    {
        Point A, B, C;
        public Triangle(Point x, Point y, Point z)
        {
            A = x;
            B = y;
            C = z;
        }

        public Triangle translate(Point t)
        {
            return new Triangle(A.add(t), B.add(t), C.add(t));
        }

        public Triangle rotate(double theta)
        {
            return new Triangle(Point.rotate(B, A, theta), B, Point.rotate(B, C, theta));
        }

        public bool isInside(Point t)
        {
            double a1 = Point.Area(A, B, C);
            double a2 = Point.Area(t, A, B) + Point.Area(t, B, C) + Point.Area(t, C, A);
            return a1 == a2;
        }
    }
}
