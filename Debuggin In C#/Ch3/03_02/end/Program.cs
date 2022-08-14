using System;
using System.Linq;

namespace _03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {10, 2, 38, 19, 5};
            Console.WriteLine(numbers[0]);
            // Console.WriteLine(numbers[-1]);
            // Console.WriteLine(numbers[5]);

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum = sum + numbers[i];
            }
            Console.WriteLine(sum);

            sum = 0;
            foreach(int num in numbers) {
                sum = sum + num;
            }
            Console.WriteLine(sum);

            int total = (from num in numbers select num).Sum();
            Console.WriteLine(total);
        }
    }
}
