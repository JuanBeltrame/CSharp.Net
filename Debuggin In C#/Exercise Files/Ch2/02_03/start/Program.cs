using System;
using System.Text;

namespace _02_03
{
    class Math
    {
        static int doubler(int x) {
           return x * x;
 
        }

        static void addGenericLastName(StringBuilder name) {
           name.Append("Smith");
        }

        static void Main(string[] args)
        {
            doubler(2);
            StringBuilder n = new StringBuilder("Sally");
            addGenericLastName(n);
            Console.WriteLine(n);
        }
    }

}
