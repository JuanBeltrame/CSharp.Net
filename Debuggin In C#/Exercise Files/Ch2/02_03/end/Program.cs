using System;
using System.Text;

namespace _02_03
{
    class Math
    {
        static int doubler(int x) {
           return x * x;
 
        }

        static String addGenericLastName(String name) {
           return name + " Smith";
        }

        static void Main(string[] args)
        {
            doubler(2);
            String n = "Sally";
            String fullName = addGenericLastName(n);
            Console.WriteLine(n);
            Console.WriteLine(fullName);
        }
    }

}
