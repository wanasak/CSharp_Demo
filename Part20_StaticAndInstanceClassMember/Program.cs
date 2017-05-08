using System;

namespace Part20_StaticAndInstanceClassMember
{
    class Circle 
    {
        // static field
        static float _pi;
        // instance field
        int _radius;

        // static constructor
        // used to initialize static fields
        // is called only once
        // is called before instance constructor
        static Circle()
        {
            Circle._pi = 3.14F;
        }

        public Circle(int radius)
        {
            this._radius = radius;
        }

        public float CalculateArea()
        {
            return Circle._pi * this._radius * this._radius;
        }
    }
     
    class MainClass
    {
        public static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            float area1 = c1.CalculateArea();
            Console.WriteLine($"Area = {area1}");

            Circle c2 = new Circle(6);
			float area2 = c2.CalculateArea();
			Console.WriteLine($"Area = {area2}");
        }
    }
}
