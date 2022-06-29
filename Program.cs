using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Sphere_Measurements
{
    abstract class SphereClass
    {
        abstract public double Radius();
        abstract public double Circumference();
        abstract public double DiskArea();
        abstract public double SurfaceArea();
        abstract public double Volume();
    }
    class Sphere : SphereClass
    {
        double radius = 0;
        const double pie = 3.14;
        public Sphere(double r)
        {
            radius = r;
        }
        public override double Radius()
        {
            return radius;
        }
        public override double Circumference()
        {
            return 2 * pie * radius;
        }
        public override double DiskArea()
        {
            return pie * radius * radius;
        }
        public override double SurfaceArea()
        {
            return 4 * pie * radius * radius;
        }
        public override double Volume()
        {
            return (4 / 3) * pie * radius * radius * radius;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Sphere obj = new Sphere(7);
            Console.WriteLine("**********Properties of a Sphere**********");
            Console.WriteLine("Radius = " + obj.Radius());
            Console.WriteLine("Circumference = " + obj.Circumference());
            Console.WriteLine("Disk Area = " + obj.DiskArea());
            Console.WriteLine("Surface Area = " + obj.SurfaceArea());
            Console.WriteLine("Volume = " + obj.Volume());
            Console.ReadLine();
        }
    }
}
