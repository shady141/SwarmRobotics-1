using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Region
    {
        List<dynamic> arr = new List<dynamic>();
        bool setComplement = false;
        bool intersection = false;

        public Region(object shape)
        {
            arr.Add(shape);
        }
        public Region() { }
        public static Region Complement(Region t)
        {
            Region r = new Region();
            r.arr = t.arr;
            r.intersection = t.intersection;
            r.setComplement = t.setComplement;
            r.setComplement = !r.setComplement;
            return r;
        }
        public static Region Intersection(Region r1, Region r2)
        {
            Region r = Region.Union(r1, r2);
            r.intersection = !r.intersection;
            return r;
        }
        public static Region Union(Region r1,Region r2)
        {
            Region o = new Region();
            foreach (var obj in r1.arr)
                o.arr.Add(obj);
            foreach (var obj in r2.arr)
                o.arr.Add(obj);
            return o;
        }
        public bool checkInside(Point a)
        {
            
            if (intersection)
            {
                bool flag = true;
                foreach (var obj in arr)
                {
                    if (!obj.isInside(a)) flag = true;
                }
                return setComplement ? !flag : flag;
            }
            else
            {
                bool flag = false;
                foreach (var obj in arr)
                {
                    if (obj.isInside(a))
                        flag = true;
                }
                return setComplement ? !flag : flag;
            }
        }
        

    }
}