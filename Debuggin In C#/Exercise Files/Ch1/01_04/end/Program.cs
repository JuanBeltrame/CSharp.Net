using System;

namespace _01_04
{
    class Program
    {

        static int findMax(int a, int b) {
            int max = a < b ? b : a;
            return max;
        }

        static void Main(string[] args)
        {
            int max = findMax(3, 8);
            Console.WriteLine(max);
        }
    }
}
