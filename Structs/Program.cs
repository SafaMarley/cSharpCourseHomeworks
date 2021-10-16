using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle classRectangle = new Rectangle();
            classRectangle.shortEdge = 4;
            classRectangle.longEdge = 5;
            Console.WriteLine("Class rectangle's area is = {0}", classRectangle.CalculateArea());

            rectangleStruct structRectangle = new rectangleStruct();
            structRectangle.shortEdge = 3;
            structRectangle.longEdge = 6;
            Console.WriteLine("Struct rectangle's area is = {0}", structRectangle.CalculateArea());
        }
    }

    class Rectangle
    {
        public int shortEdge;
        public int longEdge;

        public int CalculateArea()
        {
            return this.shortEdge * this.longEdge;
        }
    }

    //Structs can not have a default constructor like class does!
    struct rectangleStruct
    {
        public int shortEdge;
        public int longEdge;

        public int CalculateArea()
        {
            return this.shortEdge * this.longEdge;
        }
    }
}
