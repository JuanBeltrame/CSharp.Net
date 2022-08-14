using System;

namespace _04_02
{
    class Sample
    {

        static void fizzBuzz() {
            for(int i = 0; i < 100; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            fizzBuzz();
        }
    }

}
