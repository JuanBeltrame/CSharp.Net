using System;

namespace _02_01
{
     class Math
    {

        static bool isItSquare(Tuple<int, int> rect)
        {
            if (rect.Item1 <= 0 || rect.Item2 <= 0) {
                Console.WriteLine("ERROR: Not a shape");
                return false;
            } else {
                return rect.Item1 == rect.Item2;
            }
        }

        static void Main(string[] args)
        {
            Tuple<int, int> rect1 = new Tuple<int, int>(-6, -6);
            bool r = Math.isItSquare(rect1);
            Console.WriteLine(r);

            Tuple<int, int> rect2 = new Tuple<int, int>(3, 5);
            bool r2 = Math.isItSquare(rect2);
            Console.WriteLine(r2);
        }
    }

}
