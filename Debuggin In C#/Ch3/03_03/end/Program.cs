using System;

namespace _03_03
{
    class Program
    {

        static double division(int a, int b) {
            if(b == 0) {
                throw new System.DivideByZeroException("Attempted to divide by 0");
            } else {
                return a / b;
            }
        }
        static void Main(string[] args)
        {
            int a = 4;
            int b = 0;
            try {
                double result = division(a, b);
                Console.WriteLine(result);
            } catch(DivideByZeroException e) {
                double r = division(a, 1);
                Console.WriteLine(r);
            } finally {
                Console.WriteLine("FINISHED");
            }

        }
    }
}
