using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Circle
    {
        public Point center;
        public double radius;

        public Circle(Point center,double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public Circle translate(Point t)
        {
            return new Circle(center.add(t),radius);
        }

        public Circle rotate(float theta)
        {
            return new Circle(center,radius);
        }

        public virtual bool isInside(Point t)
        {
            double s = Math.Pow(t.x - center.x, 2) + Math.Pow(t.y - center.y, 2) - Math.Pow(radius, 2);
            if (s <= 0) return true;
            return false;
        }

    }
}
