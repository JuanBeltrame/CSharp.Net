using System;

namespace _01_03
{
    class Program
    {
        static double tripleNumber(double num) {
            double tripledNumber = num + 3;
            return tripledNumber;
        }

        static void Main(string[] args)
        {
            double originalNumber = 3;
            Console.WriteLine(originalNumber + 
            " tripled is " + tripleNumber(originalNumber));
        }
    }
}
