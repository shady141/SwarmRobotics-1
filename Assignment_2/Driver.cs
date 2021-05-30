using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Driver
    {
        static void Main(string[] args)
        {
            Region r1 = new Region(new Circle(new Point(-1, 0), 1));
            Region r2 = new Region(new Circle(new Point(1, 0), 1));
            Region union = Region.Union(r1, r2);
            Region inter = Region.Intersection(r1, r2);
            Region comp = Region.Complement(r1);
            Console.Write("Enter x-coordinate of point to check ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y-coordinate of point to check ");
            int y = Convert.ToInt32(Console.ReadLine());
            Point A = new Point(x, y);
            Console.WriteLine($"Point lies in r1 {r1.checkInside(A) + " "}");
            Console.WriteLine($"Point lies in r2 {r2.checkInside(A) + " "}");
            Console.WriteLine($"Point lies in union {union.checkInside(A) + " "}");
            Console.WriteLine($"Point lies in intersection {inter.checkInside(A) + " "}");
            Console.WriteLine($"Point lies in complement {comp.checkInside(A) + " "}");


        }
    }
}
