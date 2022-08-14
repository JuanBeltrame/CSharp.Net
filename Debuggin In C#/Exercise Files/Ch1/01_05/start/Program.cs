 using System;

namespace _01_05
{
    class Program
    {
        static int summation(int[] nums, int counter) {
            if (counter == -1) {
                return 0;
            } else {
                int sum = nums[counter] + summation(nums, counter - 1);
                return sum;
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = {2, 9, 20, 1, 8};
            int sum = summation(numbers, numbers.Length - 1);
            Console.WriteLine(sum);

            int[] otherNumbers = {20, 9, 17, 3};
            int otherSum = summation(otherNumbers, otherNumbers.Length - 1);
            Console.WriteLine(otherSum);
        }
    }
}
