using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Point
    {
        public double x;
        public double y;
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point() { }

        public Point add(Point t)
        {
            return new Point(x + t.x, y + t.y);
        }

        public static Point rotate(Point reference ,Point torotate,double theta)
        {
            Point ret = new Point();
            ret.x = (Math.Cos(theta) * (torotate.x - reference.x) - Math.Sin(theta) * (torotate.y - reference.y));
            ret.y = (Math.Sin(theta) * (torotate.x - reference.x) + Math.Cos(theta) * (torotate.y - reference.y));
            ret.x = Math.Round(ret.x,5);
            ret.y = Math.Round(ret.y,5);
            return ret;
        }

        public static double Area(Point p1,Point p2, Point p3)
        {
            double area = 0.5 * (p1.x * (p2.y - p3.y) + p2.x * (p3.y - p1.y) + p3.x * (p1.y - p2.y));
            return Math.Abs(area);
        }
    }
}
