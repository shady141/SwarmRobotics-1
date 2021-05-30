using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Rectange
    {
        Point A;
        Point B;
        Point C;
        Point D;
        public Rectange(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }

        public Rectange translate(Point t)
        {
            return new Rectange(A.add(t), B.add(t), C.add(t), D.add(t));
        }

        public Rectange rotate(double theta)
        {
            return new Rectange(Point.rotate(A, D, theta), B, Point.rotate(B, D, theta), Point.rotate(C, D, theta));
        }
        public bool isInside(Point t)
        {
            Point center = new Point((A.x + C.x) / 2, (A.y + C.y) / 2);
            double a1 = Point.Area(center, A, B) + Point.Area(center, B, C) + Point.Area(center, C, D) + Point.Area(center, D, A);
            double a2 = Point.Area(t, A, B) + Point.Area(t, B, C) + Point.Area(t, C, D) + Point.Area(t, D, A);
            return a1 == a2;
        }
    }
}
