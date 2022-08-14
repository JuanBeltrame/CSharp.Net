using System;

namespace _03_04
{
    class Person
    {
        String Name; 
        Person(String name) {
            this.Name = name;
        }
        public struct FictionalCharacter {
            public String fictionalName;

            public FictionalCharacter(String n) {
                fictionalName = n;
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person("Sally");
            Person person2 = person1;
            person2.Name = "Rebecca";
            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name);

            FictionalCharacter c1 = new FictionalCharacter("Harry Potter");
            FictionalCharacter c2 = c1;
            c2.fictionalName = "Hermione Granger";
            Console.WriteLine(c1.fictionalName);
            Console.WriteLine(c2.fictionalName);
        }
    }
}
