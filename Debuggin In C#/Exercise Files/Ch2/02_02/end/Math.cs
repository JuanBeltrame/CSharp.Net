using System;

namespace _02_02
{
    class Math
    {

        enum Shape {
            Error,
            Rectangle,
            Square
        }

       static void testShape(Shape s) {
            switch(s) {
                case Shape.Rectangle:
                // do things
                    Console.WriteLine("rect");
                    break;

                case Shape.Square:
                // do things
                    Console.WriteLine("square");
                    break;
                
                default:
                    throw new Exception("Shape not set");
            }
        }

        static void Main(string[] args)
        {
            Shape s = new Shape();
            Math.testShape(s);
        }
    }

}
