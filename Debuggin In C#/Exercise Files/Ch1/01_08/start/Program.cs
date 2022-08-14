using System;

namespace _01_07
{
    using System;

namespace VS_Code
{
    class Program
    {

        static int findMin(int[] arr)
        {
            int min = arr[1];
            for (int i = 0; i < arr.Length; i++) {
                int current = arr[i+1];
                if(min < current){
                    min = current;
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            int[] numbers = {1, 8, 20, 2, 3};
            integer min = findMin(numbers);
            Console.WriteLine(min);
        }
    }
}

}
