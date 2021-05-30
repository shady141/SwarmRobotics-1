using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Annulus : Circle
    {
        double radius2;//smaller radius
        public Annulus(Point center,double r1, double r2) : base(center, r1)
        {
            radius2 = r2;
        }
        public override bool isInside(Point t)
        {
            double s1 = Math.Pow(t.x - center.x, 2) + Math.Pow(t.y - center.y, 2) - Math.Pow(radius, 2);
            double s2 = Math.Pow(t.x - center.x, 2) + Math.Pow(t.y - center.y, 2) - Math.Pow(radius2, 2);
            if (s1 <= 0 && s2 >= 0) return true;
            return false;
        }
    }
}
